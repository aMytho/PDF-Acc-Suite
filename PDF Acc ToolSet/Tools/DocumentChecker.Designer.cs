namespace PDF_Acc_ToolSet.Tools
{
    partial class DocumentChecker
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
            CheckAllBtn = new Button();
            groupBox1 = new GroupBox();
            BtnExit = new Button();
            button3 = new Button();
            ResetBtn = new Button();
            groupBox2 = new GroupBox();
            ViewFailedCondionsBtn = new Button();
            ManualChecksRequiredLbl = new Label();
            button5 = new Button();
            button4 = new Button();
            label7 = new Label();
            CheckStatusLbl = new Label();
            label8 = new Label();
            label1 = new Label();
            label9 = new Label();
            FailedConditionsRemainingLbl = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // CheckAllBtn
            // 
            CheckAllBtn.Location = new Point(21, 26);
            CheckAllBtn.Name = "CheckAllBtn";
            CheckAllBtn.Size = new Size(75, 23);
            CheckAllBtn.TabIndex = 0;
            CheckAllBtn.Text = "Check All";
            CheckAllBtn.UseVisualStyleBackColor = true;
            CheckAllBtn.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnExit);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(ResetBtn);
            groupBox1.Controls.Add(CheckAllBtn);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(116, 241);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(21, 192);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 12;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // button3
            // 
            button3.Location = new Point(21, 82);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Matterhorn";
            button3.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(21, 139);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(75, 23);
            ResetBtn.TabIndex = 1;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ViewFailedCondionsBtn);
            groupBox2.Controls.Add(ManualChecksRequiredLbl);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(CheckStatusLbl);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(FailedConditionsRemainingLbl);
            groupBox2.Location = new Point(155, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 241);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Checker";
            // 
            // ViewFailedCondionsBtn
            // 
            ViewFailedCondionsBtn.Location = new Point(19, 123);
            ViewFailedCondionsBtn.Name = "ViewFailedCondionsBtn";
            ViewFailedCondionsBtn.Size = new Size(219, 23);
            ViewFailedCondionsBtn.TabIndex = 14;
            ViewFailedCondionsBtn.Text = "View";
            ViewFailedCondionsBtn.UseVisualStyleBackColor = true;
            ViewFailedCondionsBtn.Click += ViewFailedCondionsBtn_Click;
            // 
            // ManualChecksRequiredLbl
            // 
            ManualChecksRequiredLbl.AutoSize = true;
            ManualChecksRequiredLbl.Location = new Point(187, 174);
            ManualChecksRequiredLbl.Name = "ManualChecksRequiredLbl";
            ManualChecksRequiredLbl.Size = new Size(25, 15);
            ManualChecksRequiredLbl.TabIndex = 13;
            ManualChecksRequiredLbl.Text = "000";
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(127, 192);
            button5.Name = "button5";
            button5.Size = new Size(113, 23);
            button5.TabIndex = 12;
            button5.Text = "Pass All";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(19, 192);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 11;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 28);
            label7.Name = "label7";
            label7.Size = new Size(113, 37);
            label7.TabIndex = 5;
            label7.Text = "Status - ";
            // 
            // CheckStatusLbl
            // 
            CheckStatusLbl.AutoSize = true;
            CheckStatusLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CheckStatusLbl.Location = new Point(124, 28);
            CheckStatusLbl.Name = "CheckStatusLbl";
            CheckStatusLbl.Size = new Size(147, 37);
            CheckStatusLbl.TabIndex = 10;
            CheckStatusLbl.Text = "Unchecked";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 65);
            label8.Name = "label8";
            label8.Size = new Size(112, 28);
            label8.TabIndex = 7;
            label8.Text = "Matterhorn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 174);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 5;
            label1.Text = "Manual Checks Required:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 105);
            label9.Name = "label9";
            label9.Size = new Size(162, 15);
            label9.TabIndex = 8;
            label9.Text = "Failed Conditions Remaining:";
            // 
            // FailedConditionsRemainingLbl
            // 
            FailedConditionsRemainingLbl.AutoSize = true;
            FailedConditionsRemainingLbl.Location = new Point(187, 105);
            FailedConditionsRemainingLbl.Name = "FailedConditionsRemainingLbl";
            FailedConditionsRemainingLbl.Size = new Size(25, 15);
            FailedConditionsRemainingLbl.TabIndex = 9;
            FailedConditionsRemainingLbl.Text = "000";
            // 
            // DocumentChecker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 280);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "DocumentChecker";
            Text = "Document Checker";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CheckAllBtn;
        private GroupBox groupBox1;
        private Button ResetBtn;
        private Button button3;
        private Label label7;
        private Label label8;
        private Label label1;
        private Label FailedConditionsRemainingLbl;
        private Label label9;
        private GroupBox groupBox2;
        private Button button4;
        private Label CheckStatusLbl;
        private Label ManualChecksRequiredLbl;
        private Button button5;
        private Button BtnExit;
        private Button ViewFailedCondionsBtn;
    }
}