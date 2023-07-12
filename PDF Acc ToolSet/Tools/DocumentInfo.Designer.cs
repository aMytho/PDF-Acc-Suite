namespace PDF_Acc_ToolSet.Tools
{
    partial class DocumentInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            CancelBtn = new Button();
            StandardCmBox = new ComboBox();
            label3 = new Label();
            SaveBtn = new Button();
            LanguageCmBox = new ComboBox();
            TitleTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CancelBtn);
            groupBox1.Controls.Add(StandardCmBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(LanguageCmBox);
            groupBox1.Controls.Add(TitleTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Document Info";
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(141, 177);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(128, 23);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Cancel Changes";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // StandardCmBox
            // 
            StandardCmBox.FormattingEnabled = true;
            StandardCmBox.Items.AddRange(new object[] { "None", "UA" });
            StandardCmBox.Location = new Point(137, 110);
            StandardCmBox.Name = "StandardCmBox";
            StandardCmBox.Size = new Size(121, 23);
            StandardCmBox.TabIndex = 6;
            StandardCmBox.Text = "None";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 113);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Standard";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(23, 177);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 4;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LanguageCmBox
            // 
            LanguageCmBox.FormattingEnabled = true;
            LanguageCmBox.Items.AddRange(new object[] { "en-US", "en", "af", "ar", "es", "fr", "pl", "ru", "zh" });
            LanguageCmBox.Location = new Point(137, 69);
            LanguageCmBox.Name = "LanguageCmBox";
            LanguageCmBox.Size = new Size(121, 23);
            LanguageCmBox.TabIndex = 3;
            // 
            // TitleTxt
            // 
            TitleTxt.Location = new Point(137, 30);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.Size = new Size(100, 23);
            TitleTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Language";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // DocumentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(341, 293);
            Controls.Add(groupBox1);
            Name = "DocumentInfo";
            Text = "Document Info";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox TitleTxt;
        private ComboBox LanguageCmBox;
        private Button SaveBtn;
        private ComboBox StandardCmBox;
        private Label label3;
        private Button CancelBtn;
    }
}