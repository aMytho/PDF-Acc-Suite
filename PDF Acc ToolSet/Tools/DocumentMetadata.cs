namespace PDF_Acc_ToolSet.Tools
{
    public struct DocumentMetadata
    {
        // The title of the document.
        public string Title;
        // The main language of the document. Can be over-ridden in specific tags
        public string Language;
        // The PDF standard. Usually none or UA (universally accessible)
        public string Standard;

        // Constructor, assign initial values
        public DocumentMetadata(string title, string language, string standard)
        {
            this.Title = title;
            this.Language = language;
            this.Standard = standard;
        }

        public DocumentMetadata(string title)
        {
            this.Title = title;
            this.Language = "en-US";
            this.Standard = "None";
        }
    }
}