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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            FileUpload = new Button();
            ToolGroupBox = new GroupBox();
            TagCheckerBtn = new Button();
            TblGenBtn = new Button();
            ListGenBtn = new Button();
            FileUploadDialogue = new OpenFileDialog();
            SuccessLbl = new Label();
            SaveBtn = new Button();
            CancelBtn = new Button();
            FileSaveDialogue = new SaveFileDialog();
            ToolGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 18);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 0;
            label1.Text = "PDF Acc Tools";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 55);
            label2.Name = "label2";
            label2.Size = new Size(229, 19);
            label2.TabIndex = 1;
            label2.Text = "Select a PDF and then choose a tool";
            // 
            // FileUpload
            // 
            FileUpload.AllowDrop = true;
            FileUpload.BackColor = Color.SkyBlue;
            FileUpload.FlatAppearance.BorderSize = 2;
            FileUpload.FlatStyle = FlatStyle.Flat;
            FileUpload.Location = new Point(28, 93);
            FileUpload.Name = "FileUpload";
            FileUpload.Size = new Size(195, 65);
            FileUpload.TabIndex = 3;
            FileUpload.Text = "Upload";
            FileUpload.UseVisualStyleBackColor = false;
            FileUpload.Click += FileUpload_Click;
            FileUpload.DragDrop += FileUpload_DragDrop;
            FileUpload.DragOver += FileUpload_DragOver;
            // 
            // ToolGroupBox
            // 
            ToolGroupBox.Controls.Add(TagCheckerBtn);
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
            // TagCheckerBtn
            // 
            TagCheckerBtn.BackColor = Color.Azure;
            TagCheckerBtn.FlatAppearance.BorderSize = 2;
            TagCheckerBtn.FlatStyle = FlatStyle.Flat;
            TagCheckerBtn.Location = new Point(37, 123);
            TagCheckerBtn.Name = "TagCheckerBtn";
            TagCheckerBtn.Padding = new Padding(2);
            TagCheckerBtn.Size = new Size(121, 35);
            TagCheckerBtn.TabIndex = 2;
            TagCheckerBtn.Text = "Verify Accessibility";
            TagCheckerBtn.UseVisualStyleBackColor = false;
            TagCheckerBtn.Click += TagCheckerBtn_Click;
            // 
            // TblGenBtn
            // 
            TblGenBtn.BackColor = Color.Azure;
            TblGenBtn.FlatAppearance.BorderSize = 2;
            TblGenBtn.FlatStyle = FlatStyle.Flat;
            TblGenBtn.Location = new Point(37, 82);
            TblGenBtn.Name = "TblGenBtn";
            TblGenBtn.Padding = new Padding(2);
            TblGenBtn.Size = new Size(121, 35);
            TblGenBtn.TabIndex = 1;
            TblGenBtn.Text = "Table Generator";
            TblGenBtn.UseVisualStyleBackColor = false;
            TblGenBtn.Click += TblGenBtn_Click;
            // 
            // ListGenBtn
            // 
            ListGenBtn.AutoSize = true;
            ListGenBtn.BackColor = Color.Azure;
            ListGenBtn.FlatAppearance.BorderColor = SystemColors.MenuText;
            ListGenBtn.FlatAppearance.BorderSize = 2;
            ListGenBtn.FlatStyle = FlatStyle.Flat;
            ListGenBtn.Location = new Point(37, 39);
            ListGenBtn.Name = "ListGenBtn";
            ListGenBtn.Padding = new Padding(2);
            ListGenBtn.Size = new Size(121, 37);
            ListGenBtn.TabIndex = 0;
            ListGenBtn.Text = "List Generator";
            ListGenBtn.UseVisualStyleBackColor = false;
            ListGenBtn.Click += ListGenBtn_Click;
            // 
            // FileUploadDialogue
            // 
            FileUploadDialogue.DefaultExt = "pdf";
            FileUploadDialogue.Filter = "PDF Files|*.pdf";
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
            // FileSaveDialogue
            // 
            FileSaveDialogue.DefaultExt = "pdf";
            FileSaveDialogue.Filter = "PDF Files|*.pdf";
            FileSaveDialogue.SupportMultiDottedExtensions = true;
            FileSaveDialogue.Title = "Export PDF";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(258, 470);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(SuccessLbl);
            Controls.Add(ToolGroupBox);
            Controls.Add(FileUpload);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Form1";
            Text = "PDF Accessibility";
            KeyDown += Form1_KeyDown;
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
        private SaveFileDialog FileSaveDialogue;
        private Button TagCheckerBtn;
    }
}