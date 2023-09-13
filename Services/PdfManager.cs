using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace PDF_Acc_Toolset.Services
{
    public class PdfManager
    {
		public static ImportOperation<PdfReader> SetInputFile(string file)
		{
			try
			{
				// load the file, close the stream when complete
				PdfReader reader = new(file);

				// Return the file
				return new ImportOperation<PdfReader>(reader, true);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static PdfImportConfig GetMetadata(PdfReader reader)
		{
            // Open the pdf in memory to get its metadata (if any)
            PdfDocument tempPDF = new(reader);

			// Create the metadata holder
			PdfImportConfig metadata = new();

			// Set the properties from the temp PDF document and the reader if they exist
			metadata.Title = tempPDF.GetDocumentInfo().GetTitle();
            if (tempPDF.GetCatalog().GetLang() != null)
            {
                metadata.Lang = tempPDF.GetCatalog().GetLang().ToString();
            }

            // Removes the temp PDF from memory
            tempPDF.Close();

			// This isn't used (yet)
			metadata.WriterConfig = new();
			
			// Return the metadata
			return metadata;
        }
    }

	public struct ImportOperation<T>
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

    public struct PdfImportConfig
    {
		/// <summary>
		/// Title of the PDF
		/// </summary>
        public string Title;
		/// <summary>
		/// Lang of the PDF. Some ISO, idk
		/// </summary>
        public string Lang;
		/// <summary>
		/// PDf standard. Probaly UA or nothing
		/// </summary>
        public string Standard;
		public WriterProperties WriterConfig;

        public PdfImportConfig(string title, string lang, string standard)
        {
            this.Title = title;
            this.Lang = lang;
            this.Standard = standard;
        }
    }
}
