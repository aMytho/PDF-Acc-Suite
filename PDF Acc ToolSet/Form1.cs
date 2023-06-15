using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Tagging;
using iText.Kernel.Pdf.Tagutils;
using PDF_Acc_ToolSet.Tools;
using PDF_Acc_ToolSet.Utils;

namespace PDF_Acc_ToolSet
{
    public partial class Form1 : Form
    {
        private iText.Layout.Document document;
        private bool documentSelected = false;
        private string uploadPath;

        public Form1()
        {
            // Load form
            InitializeComponent();
        }

        public void SetPDF(string path)
        {
            //Set up PDF Settings, load input/output files
            try
            {
                PdfReader reader = new PdfReader(path);
                // Set the PDF to the UA standard. Sets the standard, doesn't actually do anything else. Still needs manual check
                WriterProperties properties = new WriterProperties();
                properties.AddUAXmpMetadata();

                // Get the export target from the user
                if (!SetOutput())
                {
                    // Something went wrong. Reset input/output to avoid possible confusion
                    FileSaveDialogue.FileName = null;
                    FileUploadDialogue.FileName = null;
                    uploadPath = "";
                    return;
                }

                // Load the PDF writer and document
                PdfWriter writer = new PdfWriter(FileSaveDialogue.FileName, properties);
                PdfDocument pdf = new PdfDocument(reader, writer);

                // Enable tags! Must have for acc operations.
                pdf.SetTagged();

                // Load the document for editing
                document = new iText.Layout.Document(pdf);
                documentSelected = true;

                // Set the PDF info in util
                TagUtil.setRoleMap(document.GetPdfDocument().GetStructTreeRoot().GetRoleMap());

                // Enable tool selection
                ToolGroupBox.Enabled = true;

                // Notify the user that everything worked
                SuccessLbl.Visible = true;

                // Enable the save and cancel button
                SaveBtn.Enabled = true;
                CancelBtn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("There was an error reading the PDF. Check for file corruption and ensure that you have write access.", "Upload Error");
            }
        }

        private void FileUpload_DragDrop(object sender, DragEventArgs e)
        {
            // User uploaded a file! Make sure it is valid
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Any() && files.First().EndsWith(".pdf"))
            {
                // Load the PDf
                uploadPath = files.First();
                SetPDF(files.First());
            }
            else
            {
                MessageBox.Show("Invalid file. Upload one file at a time. File must be a PDF");
            }
        }

        private void FileUpload_DragOver(object sender, DragEventArgs e)
        {
            // Set the drag type to link. Ignore all other types
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ListGenBtn_Click(object sender, EventArgs e)
        {
            // Only load if document uploaded
            if (!documentSelected) return;

            // Load the new form
            ListGenerator newForm = new ListGenerator();
            // Listen for the selection
            newForm.ListGenerationCompleted += (sender, e) =>
            {
                // Selection completed, close form
                newForm.Close();

                // Create the list
                CreateList(e);
            };
            // Show the form
            newForm.ShowDialog();
        }

        private void CreateList(ListGeneration list)
        {
            // Get the tag pointer. It starts at the root of the tag tree.
            TagTreePointer tags = document.GetPdfDocument().GetTagStructureContext().GetAutoTaggingPointer();
            // Add the parent list element to the beginning of the tag tree
            tags.AddTag(0, "L");

            // For each item to be generated, add the required items
            for (int i = 0; i < list.listItems; i++)
            {
                // Add the list item.
                tags.AddTag("LI");
                // Adds the list item body
                tags.AddTag("LBody");
                if (list.addLabels)
                {
                    // Needs a label. Since we are in the item body, we need to move up a level
                    tags.MoveToParent();
                    // Add the label before the list item body
                    tags.AddTag(0, "Lbl");
                }
                // Return to the list parent element for the next iteration
                tags.MoveToParent().MoveToParent();
            }

            // Complete, move back to root
            tags.MoveToRoot();
            MessageBox.Show("Generated List!");
        }

        public void CreateTable(TableGeneration table)
        {
            // Get the tag pointer. It starts at the root of the tag tree.
            TagTreePointer tags = document.GetPdfDocument().GetTagStructureContext().GetAutoTaggingPointer();

            // Add the parent table element to the beginning of the tag tree
            tags.AddTag(0, "Table");

            // For each row to be generated, add the required columns
            for (int i = 0; i < table.rowCount; i++)
            {
                // Add the table row
                tags.AddTag("TR");
                // Adds the table column cells
                for (int j = 0; j < table.columnCount; j++)
                {
                    // If this is the first row, add header cells
                    if (i == 0)
                    {
                        tags.AddTag("TH");
                    }
                    else
                    {
                        // Its not a header row, so we add normal table cells
                        tags.AddTag("TD");
                    }

                    // Return to the parent row for the next iteration (add more columns)
                    tags.MoveToParent();
                }

                // Return to the parent table element for the next iteration (add more rows)
                tags.MoveToParent();
            }

            // Complete. Move back to root in case of other operations
            tags.MoveToRoot();
            MessageBox.Show("Generated Table!");
        }

        private void TblGenBtn_Click(object sender, EventArgs e)
        {
            // Only load if document uploaded
            if (!documentSelected) return;

            // Load the new form
            TableGenerator newForm = new TableGenerator();
            // Listen for the selection
            newForm.TableGeneratorChanged += (sender, e) =>
            {
                // Selection completed, close form
                newForm.Close();

                // Create the table
                CreateTable(e);
            };
            // Show the form
            newForm.ShowDialog();
        }

        private void FileUpload_Click(object sender, EventArgs e)
        {
            // This method is only ran if the upload btn is clicked, not file drag/drop

            // Show the file upload
            DialogResult result = FileUploadDialogue.ShowDialog(this);
            // Ensure that a file was selected, and that the file is a valid PDF.
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("No file selected.");
            }
            else if (result == DialogResult.OK && FileUploadDialogue.FileName.EndsWith(".pdf"))
            {
                // Load the PDf
                uploadPath = FileUploadDialogue.FileName;
                SetPDF(FileUploadDialogue.FileName);
            }
            else
            {
                MessageBox.Show("Invalid file. Upload one file at a time. File must be a PDF");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            document.Close();
            MessageBox.Show("Changes Saved!");
            // Restart the app to remove changes
            Application.Restart();
            // Remove any event handelers
            Environment.Exit(0);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure? All changes will be removed.", "Remove Pending Changes", MessageBoxButtons.YesNo
                );
            if (result == DialogResult.Yes)
            {
                // Delete the newly created file. It has no data, and the input is still available.
                document.Close();
                File.Delete(FileSaveDialogue.FileName);
                // Restart the app to remove changes
                Application.Restart();
                // Remove any event handelers
                Environment.Exit(0);
            }
        }

        private bool SetOutput()
        {
            // Sets the output PDF
            DialogResult result = FileSaveDialogue.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("No file selected.", "Export Not Set");
                return false;
            }
            else if (FileSaveDialogue.FileName == uploadPath)
            {
                MessageBox.Show("You cannot have the export file be the same as the input file.", "Export Not Set");
                return false;
            }
            else if (result == DialogResult.OK && FileSaveDialogue.FileName.EndsWith(".pdf"))
            {
                // If the file doesn't exist, return the output.
                if (File.Exists(FileSaveDialogue.FileName))
                {
                    MessageBox.Show("You cannot overwrite an existing PDF!", "Export Not Set");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                // Some other error
                MessageBox.Show("Error during export selection.", "Export Not Set");
                return false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Run the related shortcut
            switch (e.KeyCode)
            {
                case Keys.U:
                    FileUpload.PerformClick();
                    break;
                case Keys.L:
                    ListGenBtn.PerformClick();
                    break;
                case Keys.T:
                    TblGenBtn.PerformClick();
                    break;
                case Keys.S:
                    SaveBtn.PerformClick();
                    break;
                case Keys.C:
                    CancelBtn.PerformClick();
                    break;
            }
        }
    }
}