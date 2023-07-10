namespace PDF_Acc_ToolSet.Tools.Checker
{
    partial class SingleCondition
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLbl = new Label();
            DescriptionLbl = new Label();
            HintLbl = new Label();
            StatusLbl = new Label();
            PassBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NameLbl.Location = new Point(7, 12);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(103, 37);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "09-005";
            // 
            // DescriptionLbl
            // 
            DescriptionLbl.Location = new Point(139, 12);
            DescriptionLbl.Name = "DescriptionLbl";
            DescriptionLbl.Size = new Size(164, 115);
            DescriptionLbl.TabIndex = 1;
            DescriptionLbl.Text = "A Warichu-related structure element is used in\r\na way that does not conform to Table 338 in ISO\r\n32000-1.\r\n";
            // 
            // HintLbl
            // 
            HintLbl.Location = new Point(344, 12);
            HintLbl.Name = "HintLbl";
            HintLbl.Size = new Size(164, 115);
            HintLbl.TabIndex = 2;
            HintLbl.Text = "A Warichu-related structure element is used in\r\na way that does not conform to Table 338 in ISO\r\n32000-1.\r\n";
            // 
            // StatusLbl
            // 
            StatusLbl.AutoSize = true;
            StatusLbl.BackColor = Color.Transparent;
            StatusLbl.FlatStyle = FlatStyle.Flat;
            StatusLbl.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLbl.ForeColor = Color.Red;
            StatusLbl.Location = new Point(539, 27);
            StatusLbl.Name = "StatusLbl";
            StatusLbl.Size = new Size(68, 46);
            StatusLbl.TabIndex = 65;
            StatusLbl.Text = "❌";
            // 
            // PassBtn
            // 
            PassBtn.Enabled = false;
            PassBtn.Location = new Point(532, 104);
            PassBtn.Name = "PassBtn";
            PassBtn.Size = new Size(75, 23);
            PassBtn.TabIndex = 66;
            PassBtn.Text = "Pass";
            PassBtn.UseVisualStyleBackColor = true;
            PassBtn.Click += PassBtn_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(19, 104);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 67;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            // 
            // SingleCondition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(PassBtn);
            Controls.Add(StatusLbl);
            Controls.Add(HintLbl);
            Controls.Add(DescriptionLbl);
            Controls.Add(NameLbl);
            Name = "SingleCondition";
            Size = new Size(619, 148);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private Label DescriptionLbl;
        private Label HintLbl;
        private Label StatusLbl;
        private Button PassBtn;
        private Button button1;
    }
}
