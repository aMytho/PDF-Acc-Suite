﻿namespace PDF_Acc_ToolSet
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
            TagCounterBtn = new Button();
            TblGenBtn = new Button();
            ListGenBtn = new Button();
            FileUploadDialogue = new OpenFileDialog();
            SuccessLbl = new Label();
            SaveBtn = new Button();
            CancelBtn = new Button();
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
            FileUpload.Click += FileUpload_Click;
            FileUpload.DragDrop += FileUpload_DragDrop;
            FileUpload.DragOver += FileUpload_DragOver;
            // 
            // ToolGroupBox
            // 
            ToolGroupBox.Controls.Add(TagCounterBtn);
            ToolGroupBox.Controls.Add(TblGenBtn);
            ToolGroupBox.Controls.Add(ListGenBtn);
            ToolGroupBox.Enabled = false;
            ToolGroupBox.Location = new Point(26, 197);
            ToolGroupBox.Name = "ToolGroupBox";
            ToolGroupBox.Size = new Size(200, 209);
            ToolGroupBox.TabIndex = 4;
            ToolGroupBox.TabStop = false;
            ToolGroupBox.Text = "Tools";
            // 
            // TagCounterBtn
            // 
            TagCounterBtn.Location = new Point(56, 105);
            TagCounterBtn.Name = "TagCounterBtn";
            TagCounterBtn.Size = new Size(86, 23);
            TagCounterBtn.TabIndex = 2;
            TagCounterBtn.Text = "Tag Counter";
            TagCounterBtn.UseVisualStyleBackColor = true;
            TagCounterBtn.Click += TagCounterBtn_Click;
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
            // FileUploadDialogue
            // 
            FileUploadDialogue.DefaultExt = "pdf";
            FileUploadDialogue.ShowReadOnly = true;
            FileUploadDialogue.SupportMultiDottedExtensions = true;
            FileUploadDialogue.Title = "File Upload";
            // 
            // SuccessLbl
            // 
            SuccessLbl.AutoSize = true;
            SuccessLbl.ForeColor = Color.DarkGreen;
            SuccessLbl.Location = new Point(53, 175);
            SuccessLbl.Name = "SuccessLbl";
            SuccessLbl.Size = new Size(149, 15);
            SuccessLbl.TabIndex = 2;
            SuccessLbl.Text = "File Uploaded Successfully!";
            SuccessLbl.Visible = false;
            // 
            // SaveBtn
            // 
            SaveBtn.Enabled = false;
            SaveBtn.Location = new Point(37, 427);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Enabled = false;
            CancelBtn.Location = new Point(134, 427);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 6;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 470);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(SuccessLbl);
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
        private OpenFileDialog FileUploadDialogue;
        private Label SuccessLbl;
        private Button SaveBtn;
        private Button CancelBtn;
        private Button TagCounterBtn;
    }
}