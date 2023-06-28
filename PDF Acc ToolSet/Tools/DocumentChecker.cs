using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf.Tagutils;
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
            }
            else
            {
                FailedConditionsRemainingLbl.Text = 001.ToString();
                FailedConditionsRemainingLbl.ForeColor = Color.Red;

                CheckStatusLbl.Text = "Fail";
                CheckStatusLbl.ForeColor = Color.Red;
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

        private void ViewFailedCondionsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A list has an invalid structure");
        }
    }
}
