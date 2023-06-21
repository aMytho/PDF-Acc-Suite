namespace PDF_Acc_ToolSet.Tools
{
    partial class ListGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListGenerator));
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ListLabelCheckbox = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            ListItemAmountNumeric = new NumericUpDown();
            GenerateBtn = new Button();
            ResetBtn = new Button();
            label6 = new Label();
            TitleTxt = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListItemAmountNumeric).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TitleTxt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ListLabelCheckbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ListItemAmountNumeric);
            groupBox1.Location = new Point(24, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Options";
            // 
            // label5
            // 
            label5.Location = new Point(6, 179);
            label5.Name = "label5";
            label5.Size = new Size(260, 95);
            label5.TabIndex = 6;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 149);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Structure:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 134);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // ListLabelCheckbox
            // 
            ListLabelCheckbox.AutoSize = true;
            ListLabelCheckbox.Location = new Point(146, 77);
            ListLabelCheckbox.Name = "ListLabelCheckbox";
            ListLabelCheckbox.Size = new Size(80, 19);
            ListLabelCheckbox.TabIndex = 3;
            ListLabelCheckbox.Text = "(Optional)";
            ListLabelCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 78);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Include Labels?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 38);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of List Items";
            // 
            // ListItemAmountNumeric
            // 
            ListItemAmountNumeric.Location = new Point(146, 36);
            ListItemAmountNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ListItemAmountNumeric.Name = "ListItemAmountNumeric";
            ListItemAmountNumeric.Size = new Size(120, 23);
            ListItemAmountNumeric.TabIndex = 0;
            ListItemAmountNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(35, 325);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(75, 23);
            GenerateBtn.TabIndex = 1;
            GenerateBtn.Text = "Generate";
            GenerateBtn.UseVisualStyleBackColor = true;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(215, 325);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(75, 23);
            ResetBtn.TabIndex = 2;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 119);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 7;
            label6.Text = "Title of Element";
            // 
            // TitleTxt
            // 
            TitleTxt.Location = new Point(147, 117);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.PlaceholderText = "Optional";
            TitleTxt.Size = new Size(100, 23);
            TitleTxt.TabIndex = 8;
            // 
            // ListGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 372);
            Controls.Add(ResetBtn);
            Controls.Add(GenerateBtn);
            Controls.Add(groupBox1);
            KeyPreview = true;
            Name = "ListGenerator";
            Text = "ListGenerator";
            KeyDown += ListGenerator_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListItemAmountNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button GenerateBtn;
        private Button ResetBtn;
        private Label label1;
        private NumericUpDown ListItemAmountNumeric;
        private CheckBox ListLabelCheckbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TitleTxt;
        private Label label6;
    }
}