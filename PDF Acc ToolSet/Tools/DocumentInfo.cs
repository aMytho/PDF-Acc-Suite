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
    public partial class DocumentInfo : Form
    {
        public event EventHandler<DocumentMetadata> DocumentInfoConfirmed;
        public event EventHandler<DocumentMetadata> DocumentInfoUnchanged;

        // Keep a copy of the initial metadata. This won't change
        public readonly DocumentMetadata meta;

        public DocumentInfo(DocumentMetadata meta, bool showCancel)
        {
            InitializeComponent();

            // Set the document info.
            TitleTxt.Text = meta.Title;
            LanguageCmBox.Text = meta.Language;

            // TO-do: allow other standards
            if (!meta.Standard.Equals("None"))
            {
                StandardCmBox.Text = "UA";
            }
            else
            {
                StandardCmBox.Text = meta.Standard;
            }

            // Store a copy of the original values in case the user cancels the changes
            this.meta = meta;

            // Based on where this form is being used, change the button text (import or modify)
            if (showCancel)
            {
                CancelBtn.Text = "Cancel";
            }
            else
            {
                CancelBtn.Text = "Leave Unchanged";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Emit the values to the main form
            DocumentInfoConfirmed?.Invoke(this, new DocumentMetadata(TitleTxt.Text, LanguageCmBox.Text, StandardCmBox.Text));
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            // Emit the values to the main form, no data/changes
            DocumentInfoConfirmed?.Invoke(this, new DocumentMetadata(meta.Title, meta.Language, meta.Standard));
        }
    }
}
