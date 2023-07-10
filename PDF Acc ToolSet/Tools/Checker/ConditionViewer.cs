using PDF_Acc_ToolSet.Utils;
using PDF_Acc_ToolSet.Utils.Checks;

namespace PDF_Acc_ToolSet.Tools.Checker
{
    /// <summary>
    /// A better name would be checkpoint viewer :)
    /// </summary>
    public partial class ConditionViewer : Form
    {
        public ConditionViewer(Checkpoint checkpoint)
        {
            InitializeComponent();
            // For each check in the checkpoint, add it to the flow panel
            foreach (Check check in checkpoint.checks)
            {
                SingleCondition singleCondition = new(check, "None");
                singleCondition.PassedCheck += (sender, e) =>
                {
                    // The check was passed manually
                    check.status = CheckStatus.Success;
                    UpdateCheckpointStatus();
                };
                CheckFlow.Controls.Add(singleCondition);
            }
            foreach (Check check in checkpoint.checks)
            {
                SingleCondition singleCondition = new(check, "None");
                CheckFlow.Controls.Add(singleCondition);
            }
            foreach (Check check in checkpoint.checks)
            {
                SingleCondition singleCondition = new(check, "None");
                CheckFlow.Controls.Add(singleCondition);
            }
        }

        private void UpdateCheckpointStatus()
        {
            // Check if all have been passed/failed
        }
    }
}
