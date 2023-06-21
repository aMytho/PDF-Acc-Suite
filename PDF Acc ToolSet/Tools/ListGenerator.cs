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
            string listTitle = TitleTxt.Text;

            // Emit the values to the main form
            ListGenerationCompleted?.Invoke(this, new ListGeneration(amountOfLists, addLabels, listTitle));
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ListItemAmountNumeric.Value = 1;
            ListLabelCheckbox.Checked = false;
        }

        private void ListGenerator_KeyDown(object sender, KeyEventArgs e)
        {
            // Run the related shortcut
            switch (e.KeyCode)
            {
                case Keys.N:
                    ListItemAmountNumeric.Focus();
                    break;
                case Keys.L:
                    ListLabelCheckbox.Checked = !ListLabelCheckbox.Checked;
                    break;
                case Keys.G:
                    GenerateBtn.PerformClick();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
