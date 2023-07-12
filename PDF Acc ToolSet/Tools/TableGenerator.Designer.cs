namespace PDF_Acc_ToolSet.Tools
{
    partial class TableGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableGenerator));
            groupBox1 = new GroupBox();
            RowHeadersCmbBox = new CheckBox();
            label5 = new Label();
            TitleTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TableRowAmountNumeric = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            TableColumnAmountNumeric = new NumericUpDown();
            GenerateBtn = new Button();
            ResetBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableRowAmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TableColumnAmountNumeric).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RowHeadersCmbBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TitleTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TableRowAmountNumeric);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TableColumnAmountNumeric);
            groupBox1.Location = new Point(22, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 333);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Table Generator";
            // 
            // RowHeadersCmbBox
            // 
            RowHeadersCmbBox.AutoSize = true;
            RowHeadersCmbBox.Location = new Point(127, 155);
            RowHeadersCmbBox.Name = "RowHeadersCmbBox";
            RowHeadersCmbBox.Size = new Size(80, 19);
            RowHeadersCmbBox.TabIndex = 7;
            RowHeadersCmbBox.Text = "(Optional)";
            RowHeadersCmbBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 156);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 6;
            label5.Text = "Add Row Headers?";
            // 
            // TitleTxt
            // 
            TitleTxt.Location = new Point(127, 114);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.PlaceholderText = "Optional";
            TitleTxt.Size = new Size(100, 23);
            TitleTxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 117);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 4;
            label4.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 36);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 3;
            label3.Text = "Table Columns";
            // 
            // TableRowAmountNumeric
            // 
            TableRowAmountNumeric.Location = new Point(127, 73);
            TableRowAmountNumeric.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            TableRowAmountNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TableRowAmountNumeric.Name = "TableRowAmountNumeric";
            TableRowAmountNumeric.Size = new Size(120, 23);
            TableRowAmountNumeric.TabIndex = 2;
            TableRowAmountNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Location = new Point(6, 203);
            label2.Name = "label2";
            label2.Size = new Size(254, 113);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 77);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Table Rows";
            // 
            // TableColumnAmountNumeric
            // 
            TableColumnAmountNumeric.Location = new Point(127, 32);
            TableColumnAmountNumeric.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            TableColumnAmountNumeric.Name = "TableColumnAmountNumeric";
            TableColumnAmountNumeric.Size = new Size(120, 23);
            TableColumnAmountNumeric.TabIndex = 0;
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(53, 384);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(75, 23);
            GenerateBtn.TabIndex = 1;
            GenerateBtn.Text = "Generate";
            GenerateBtn.UseVisualStyleBackColor = true;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(174, 384);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(75, 23);
            ResetBtn.TabIndex = 2;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // TableGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(317, 437);
            Controls.Add(ResetBtn);
            Controls.Add(GenerateBtn);
            Controls.Add(groupBox1);
            KeyPreview = true;
            Name = "TableGenerator";
            Text = "TableGenerator";
            KeyDown += TableGenerator_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TableRowAmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)TableColumnAmountNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown TableColumnAmountNumeric;
        private Label label3;
        private NumericUpDown TableRowAmountNumeric;
        private Label label2;
        private Label label1;
        private Button GenerateBtn;
        private Button ResetBtn;
        private TextBox TitleTxt;
        private Label label4;
        private CheckBox RowHeadersCmbBox;
        private Label label5;
    }
}