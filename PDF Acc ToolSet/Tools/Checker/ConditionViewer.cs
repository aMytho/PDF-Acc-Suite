using PDF_Acc_ToolSet.Utils;
using PDF_Acc_ToolSet.Utils.Checks;

namespace PDF_Acc_ToolSet.Tools.Checker
{
    /// <summary>
    /// A better name would be checkpoint viewer :)
    /// </summary>
    public partial class ConditionViewer : Form
    {
        private Checkpoint checkpoint;

        public ConditionViewer(Checkpoint checkpoint)
        {
            InitializeComponent();
            // Set the checkpoint for Matterhorn documentation
            this.checkpoint = checkpoint;
            
            // For each check in the checkpoint, add it to the flow panel
            foreach (Check check in checkpoint.checks)
            {
                SingleCondition singleCondition = new(check, "None");
                singleCondition.PassedCheck += (sender, e) =>
                {
                    // The check was passed manually
                    check.status = CheckStatus.Success;
                    UpdateConditionViewer();
                };
                CheckFlow.Controls.Add(singleCondition);
            }

            // Enable the manual check btn a manual check exists
            foreach (Check check in checkpoint.checks)
            {
                if (check.validator == Validator.Machine)
                {
                    PassChecksBtn.Enabled = true;
                    break;
                }

            }
        }

        private void UpdateConditionViewer()
        {
            // Check if all have passed
            foreach (Check check in checkpoint.checks)
            {
                if (check.status != CheckStatus.Success)
                    return;
            }

            // All are valid, show that on the form
            StatusLbl.Text = "Valid";
            StatusLbl.ForeColor = Color.ForestGreen;
        }

        private void PassChecksBtn_Click(object sender, EventArgs e)
        {
            // Set each manual check as success
            foreach (Check check in checkpoint.checks)
            {
                if (check.validator == Validator.Human)
                {
                    check.status = CheckStatus.Success;
                }
            }

            MessageBox.Show("All manual checks have been marked as passed.", "Manaul Check Complete");

            // If all checks are now passed, we need to update the UI
            UpdateConditionViewer();
        }

        private void MatterhornBtn_Click(object sender, EventArgs e)
        {
            // Open the matterhorn documentation
            Documentation.OpenMatterhorn(checkpoint.matterhornLocation);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
