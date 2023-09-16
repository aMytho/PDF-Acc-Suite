using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace PDF_Acc_Toolset.Services
{
    public class PdfManager
    {
		/// <summary>
		/// Store the active PDF
		/// </summary>
		private static Document document;

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

			// Create a blank writer config
			metadata.WriterConfig = new();
			
			// Return the metadata
			return metadata;
        }

		public static void SetOutputFile(string path, string inputPath, PdfImportConfig conf)
		{
			// Adjust metadata (if needed)
			if (conf.Standard.Equals("UA"))
			{
				// TO-DO: add the other standards
				conf.WriterConfig.AddUAXmpMetadata();
			}

			// Load the file from disk, apply config
			PdfWriter writer = new(path, conf.WriterConfig);
			PdfDocument pdf = new(new PdfReader(inputPath), writer);
			
			// Store the document in the manager
			document = new Document(pdf);

			// Enable tagging (or load existing tags)
			pdf.SetTagged();
			// Set lang
            pdf.GetCatalog().SetLang(new PdfString(conf.Lang));
            // Set the title
            pdf.GetDocumentInfo().SetTitle(conf.Title);
			// Display the document title instead of file name (acc)
            pdf.GetCatalog().SetViewerPreferences(new PdfViewerPreferences().SetDisplayDocTitle(true));
            
			// To-do: role map
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
		/// <summary>
		/// The filename of the PDF
		/// </summary>
		public string Filename;
		public WriterProperties WriterConfig;

        public PdfImportConfig(string title, string lang, string standard, string filename)
        {
            this.Title = title;
            this.Lang = lang;
            this.Standard = standard;
			this.Filename = filename;
        }
    }
}
