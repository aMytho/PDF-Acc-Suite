using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Tagutils;
using PDF_Acc_ToolSet.Tools;

namespace PDF_Acc_ToolSet
{
    public partial class Form1 : Form
    {
        private iText.Layout.Document document;
        private bool documentSelected = false;
        public Form1()
        {
            // Load form
            InitializeComponent();
        }

        public void SetPDF(string path)
        {
            //Set up PDF Settings, load input/output files
            PdfReader reader = new PdfReader(path);
            PdfWriter writer = new PdfWriter("./new.pdf");
            PdfDocument pdf = new PdfDocument(reader, writer);

            // Enable tags! Must have for acc operations.
            pdf.SetTagged();

            // Load the document for editing
            document = new iText.Layout.Document(pdf);
            documentSelected = true;
        }

        private void FileUpload_DragDrop(object sender, DragEventArgs e)
        {
            // Usr uploaded a file! Make sure it is valid
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
            {
                MessageBox.Show(files.First().ToString());
                SetPDF(files.First().ToString());
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

            // Save changes
            document.Close();
            MessageBox.Show("Done!");
        }

        private void TblGenBtn_Click(object sender, EventArgs e)
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
    }
}