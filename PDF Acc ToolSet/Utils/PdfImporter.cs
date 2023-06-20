using iText.Kernel.Pdf;
using PDF_Acc_ToolSet.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Acc_ToolSet.Utils
{
    internal static class PdfImporter
    {
        public static ImportOperation<PdfReader> OpenInput(string path)
        {
            try
            {
                PdfReader reader = new(path);
                return new ImportOperation<PdfReader>(reader, true);
            } catch (Exception)
            {
                return new ImportOperation<PdfReader>();
            }
        }

        public static Task<ImportOperation<WriterWithMetadata>> SetOutputMetadata(PdfReader reader)
        {
            // Create the return task.
            TaskCompletionSource<ImportOperation<WriterWithMetadata>> tsc = new();

            // Create the writer config
            WriterProperties properties = new();
            
            // Create PDf metadata
            DocumentMetadata metadata = new("Default");
            // Open the pdf in memory to get its metadata (if any)
            PdfDocument tempPDF = new(reader);

            // Set the properties from the temp PDF document and the reader if they exist
            metadata.Title = tempPDF.GetDocumentInfo().GetTitle();
            if (tempPDF.GetCatalog().GetLang() != null)
            {
                metadata.Language = tempPDF.GetCatalog().GetLang().ToString();
            }
            
            // Set standard. To-do: get existing standard
            metadata.Standard = "None";

            // Removes the temp PDF from memory
            tempPDF.Close();

            // Create the form for importing a PDF. This allows the user to modify the properties above
            DocumentInfo form = new(metadata, false);
            // Listen for the form events. Either saved with changes, or keep existing
            form.DocumentInfoConfirmed += (sender, e) =>
            {                
                form.Close();
                tsc.SetResult(SetWriterProps(properties, e));
            };
            form.DocumentInfoUnchanged += (sender, e) =>
            {
                form.Close();
                tsc.SetResult(SetWriterProps(properties, metadata));
            };
            // Show the form
            form.ShowDialog();

            // Return the task value. The caller listens for its completion
            return tsc.Task;
        }

        private static ImportOperation<WriterWithMetadata> SetWriterProps(WriterProperties properties, DocumentMetadata meta)
        {
            // Add UA standard if set
            if (!meta.Standard.Equals("None"))
            {
                properties.AddUAXmpMetadata();
            }
            // To-do: Add other standard checks. ATM, if its not none, its UA.

            return new ImportOperation<WriterWithMetadata>(new WriterWithMetadata(meta, properties), true);
        }
    }

    internal struct ImportOperation<T>
    {
        // The data from the operation
        public T Data;
        // Did the operation succeed?
        public bool success;

        // Success, or failure but the data must be returned
        public ImportOperation(T Data, bool success)
        {
            this.Data = Data;
            this.success = success;
        }

        // Handle failed cases
        public ImportOperation()
        {
            success = false;
        }
    }

    internal struct WriterWithMetadata
    {
        // The metadata for the writer
        public DocumentMetadata meta;
        // The writer itself
        public WriterProperties writer;

        public WriterWithMetadata(DocumentMetadata meta, WriterProperties writer)
        {
            this.meta = meta;
            this.writer = writer;
        }

        public WriterWithMetadata() {}
    }
}
