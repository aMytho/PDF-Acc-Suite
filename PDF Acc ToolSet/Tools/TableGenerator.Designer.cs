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
            groupBox1 = new GroupBox();
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
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TableRowAmountNumeric);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TableColumnAmountNumeric);
            groupBox1.Location = new Point(22, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Table Generator";
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
            label2.Location = new Point(10, 107);
            label2.Name = "label2";
            label2.Size = new Size(254, 61);
            label2.TabIndex = 1;
            label2.Text = "Each table will a set amount of rows and columns. The first row will contain header cells. Each row has the same amount of columns by default.";
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
            GenerateBtn.Location = new Point(42, 239);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(75, 23);
            GenerateBtn.TabIndex = 1;
            GenerateBtn.Text = "Generate";
            GenerateBtn.UseVisualStyleBackColor = true;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(169, 239);
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
            ClientSize = new Size(317, 285);
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
    }
}