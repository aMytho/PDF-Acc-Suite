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
            EventHandler<TableGeneration> handler = TableGeneratorChanged;
            if (handler != null)
            {
                handler(this, new TableGeneration(rowCount, columnCount));
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            TableColumnAmountNumeric.Value = 0;
            TableRowAmountNumeric.Value = 0;
        }
    }
}
