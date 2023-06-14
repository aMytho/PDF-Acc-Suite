namespace PDF_Acc_ToolSet.Tools
{
    public partial class ListGenerator : Form
    {
        public event EventHandler<ListGeneration> ListGenerationCompleted;

        public ListGenerator()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            // Get the selection from the user
            int amountOfLists = (int)ListItemAmountNumeric.Value;
            bool addLabels = ListLabelCheckbox.Checked;

            // Check for invalid values


            // Emit the values to the main form
            EventHandler<ListGeneration> handler = ListGenerationCompleted;
            if (handler != null)
            {
                handler(this, new ListGeneration(amountOfLists, addLabels));
            }
        }
    }
}
