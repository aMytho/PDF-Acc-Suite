using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Acc_ToolSet.Tools
{
    public partial class TableGenerator : Form
    {
        public event EventHandler<TableGeneration> TableGeneratorChanged;

        public TableGenerator()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            // Get the selection from the user
            int columnCount = (int)TableColumnAmountNumeric.Value;
            int rowCount = (int)TableRowAmountNumeric.Value;

            // Check for invalid values


            // Emit the values to the main form
            TableGeneratorChanged?.Invoke(this, new TableGeneration(rowCount, columnCount, TitleTxt.Text.Trim()));
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            TableColumnAmountNumeric.Value = 0;
            TableRowAmountNumeric.Value = 1;
        }

        private void TableGenerator_KeyDown(object sender, KeyEventArgs e)
        {
            // Run the related shortcut
            switch (e.KeyCode)
            {
                case Keys.C:
                    TableColumnAmountNumeric.Focus();
                    break;
                case Keys.R:
                    TableRowAmountNumeric.Focus();
                    break;
                case Keys.Escape:
                    Close();
                    break;
                case Keys.G:
                    GenerateBtn.PerformClick();
                    break;
            }
        }
    }
}
