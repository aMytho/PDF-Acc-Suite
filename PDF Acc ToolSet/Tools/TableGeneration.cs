namespace PDF_Acc_ToolSet.Tools
{
    public struct TableGeneration
    {
        // The amount of rows to generate
        public int rowCount;
        // The amount of columns per row
        public int columnCount;

        // Constructor, assign initial values
        public TableGeneration(int rowCount, int columnCount)
        {
            this.rowCount = rowCount;
            this.columnCount = columnCount;
        }
    }
}