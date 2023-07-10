using PDF_Acc_ToolSet.Utils;

namespace PDF_Acc_ToolSet.Tools.Checker
{
    public partial class SingleCondition : UserControl
    {
        public event EventHandler<Check> PassedCheck;
        private Check check;

        private SingleCondition()
        {
            InitializeComponent();
        }

        public SingleCondition(Check check, string hint)
        {
            InitializeComponent();
            this.check = check;

            // Set the name
            NameLbl.Text = check.index;
            // Set the hint (if any)
            if (hint != null)
            {
                HintLbl.Text = hint;
            }
            // Set the status
            if (check.status == CheckStatus.Failure)
            {
                StatusLbl.Text = "❌";
                StatusLbl.ForeColor = Color.Red;
            }
            else
            {
                StatusLbl.Text = "✓";
                StatusLbl.ForeColor = Color.ForestGreen;
            }

            // If a manual check, enable the button for passing it
            if (check.validator == Validator.Human)
            {
                PassBtn.Enabled = true;
            }
        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            // Emit that the check should be passed
            PassedCheck?.Invoke(this, check);
        }
    }
}
