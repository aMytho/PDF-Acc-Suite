using iText.Kernel.Pdf.Tagutils;
using PDF_Acc_ToolSet.Tools.Checker;
//using MaterialSkin.Controls;
using PDF_Acc_ToolSet.Utils.Checks;

namespace PDF_Acc_ToolSet.Tools
{
    public partial class DocumentChecker : Form
    {
        private readonly Checkpoint9 checkpoint9;
        private int totalMachineChecks = 1;
        private int totalHumanChecks = 0;
        private int failedMachineChecks = 0;
        private int failedHumanChecks = 0;

        public DocumentChecker(TagTreePointer pointer)
        {
            InitializeComponent();

            // Set the UI initial values
            FailedConditionsRemainingLbl.Text = (totalHumanChecks + totalMachineChecks).ToString();
            ManualChecksRequiredLbl.Text = totalHumanChecks.ToString();

            // Give each checkpoint the data they need
            checkpoint9 = new(pointer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // At the moment we only check checkpoint 9 check 5
            if (checkpoint9.Check005.RunCheck() == Utils.CheckStatus.Success)
            {
                FailedConditionsRemainingLbl.Text = 000.ToString();
                FailedConditionsRemainingLbl.ForeColor = Color.Green;

                CheckStatusLbl.Text = "Pass";
                CheckStatusLbl.ForeColor = Color.Green;

                // To-do: Increment this. Since we only have 1 check this is acceptable for now
                label95.Text = "0";
                label94.Text = "1";
            }
            else
            {
                FailedConditionsRemainingLbl.Text = 001.ToString();
                FailedConditionsRemainingLbl.ForeColor = Color.Red;

                CheckStatusLbl.Text = "Fail";
                CheckStatusLbl.ForeColor = Color.Red;

                // To-do: Increment this. Since we only have 1 check this is acceptable for now
                label95.Text = "1";
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            failedMachineChecks = 1;
            failedHumanChecks = 0;
            CheckStatusLbl.Text = "Unchecked";
            CheckStatusLbl.ForeColor = Color.Black;
        }

        private void Check9Btn_Click(object sender, EventArgs e)
        {
            ConditionViewer viewer = new(checkpoint9);
            viewer.Show();
        }
    }
}
