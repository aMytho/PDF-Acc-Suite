namespace PDF_Acc_ToolSet.Tools
{
    public struct TableGeneration
    {
        // The amount of rows to generate
        public int rowCount;
        // The amount of columns per row
        public int columnCount;
        // The title of the element
        public string title;
        // Whether or not to set the first cell in each row as a header
        public bool addRowHeaders;

        // Constructor, assign initial values
        public TableGeneration(int rowCount, int columnCount, string title, bool addRowHeaders)
        {
            this.rowCount = rowCount;
            this.columnCount = columnCount;
            this.title = title;
            this.addRowHeaders = addRowHeaders;
        }
    }
}