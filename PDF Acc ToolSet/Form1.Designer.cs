namespace PDF_Acc_ToolSet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            FileUpload = new Button();
            ToolGroupBox = new GroupBox();
            ListGenBtn = new Button();
            TblGenBtn = new Button();
            ToolGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 21);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "PDF Acc Tools";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(195, 15);
            label2.TabIndex = 1;
            label2.Text = "Select a PDF and then choose a tool";
            // 
            // FileUpload
            // 
            FileUpload.AllowDrop = true;
            FileUpload.Location = new Point(28, 93);
            FileUpload.Name = "FileUpload";
            FileUpload.Size = new Size(195, 65);
            FileUpload.TabIndex = 3;
            FileUpload.Text = "Upload";
            FileUpload.UseVisualStyleBackColor = true;
            FileUpload.DragDrop += FileUpload_DragDrop;
            FileUpload.DragOver += FileUpload_DragOver;
            // 
            // ToolGroupBox
            // 
            ToolGroupBox.Controls.Add(TblGenBtn);
            ToolGroupBox.Controls.Add(ListGenBtn);
            ToolGroupBox.Location = new Point(28, 181);
            ToolGroupBox.Name = "ToolGroupBox";
            ToolGroupBox.Size = new Size(200, 243);
            ToolGroupBox.TabIndex = 4;
            ToolGroupBox.TabStop = false;
            ToolGroupBox.Text = "Tools";
            // 
            // ListGenBtn
            // 
            ListGenBtn.AutoSize = true;
            ListGenBtn.Location = new Point(56, 22);
            ListGenBtn.Name = "ListGenBtn";
            ListGenBtn.Size = new Size(90, 25);
            ListGenBtn.TabIndex = 0;
            ListGenBtn.Text = "List Generator";
            ListGenBtn.UseVisualStyleBackColor = true;
            ListGenBtn.Click += ListGenBtn_Click;
            // 
            // TblGenBtn
            // 
            TblGenBtn.Location = new Point(51, 64);
            TblGenBtn.Name = "TblGenBtn";
            TblGenBtn.Size = new Size(99, 23);
            TblGenBtn.TabIndex = 1;
            TblGenBtn.Text = "Table Generator";
            TblGenBtn.UseVisualStyleBackColor = true;
            TblGenBtn.Click += TblGenBtn_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 450);
            Controls.Add(ToolGroupBox);
            Controls.Add(FileUpload);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "PDF LifeSaver";
            ToolGroupBox.ResumeLayout(false);
            ToolGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button FileUpload;
        private GroupBox ToolGroupBox;
        private Button ListGenBtn;
        private Button TblGenBtn;
    }
}