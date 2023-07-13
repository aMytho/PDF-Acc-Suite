namespace PDF_Acc_ToolSet.Tools.Checker
{
    partial class ConditionViewer
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
            ChecksBox = new GroupBox();
            CheckFlow = new FlowLayoutPanel();
            ExitBtn = new Button();
            PassChecksBtn = new Button();
            groupBox1 = new GroupBox();
            StatusLbl = new Label();
            ChekpointLbl = new Label();
            MatterhornBtn = new Button();
            ChecksBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ChecksBox
            // 
            ChecksBox.Controls.Add(CheckFlow);
            ChecksBox.Location = new Point(153, 12);
            ChecksBox.Name = "ChecksBox";
            ChecksBox.Size = new Size(723, 389);
            ChecksBox.TabIndex = 0;
            ChecksBox.TabStop = false;
            ChecksBox.Text = "Checks";
            // 
            // CheckFlow
            // 
            CheckFlow.AutoScroll = true;
            CheckFlow.Location = new Point(19, 26);
            CheckFlow.Name = "CheckFlow";
            CheckFlow.Size = new Size(679, 345);
            CheckFlow.TabIndex = 0;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(11, 348);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(93, 23);
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "Close";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // PassChecksBtn
            // 
            PassChecksBtn.Enabled = false;
            PassChecksBtn.Location = new Point(11, 175);
            PassChecksBtn.Name = "PassChecksBtn";
            PassChecksBtn.Size = new Size(93, 64);
            PassChecksBtn.TabIndex = 5;
            PassChecksBtn.Text = "Pass Manual Checks";
            PassChecksBtn.UseVisualStyleBackColor = true;
            PassChecksBtn.Click += PassChecksBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(StatusLbl);
            groupBox1.Controls.Add(ChekpointLbl);
            groupBox1.Controls.Add(MatterhornBtn);
            groupBox1.Controls.Add(ExitBtn);
            groupBox1.Controls.Add(PassChecksBtn);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(117, 389);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls";
            // 
            // StatusLbl
            // 
            StatusLbl.AutoSize = true;
            StatusLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StatusLbl.Location = new Point(32, 134);
            StatusLbl.Name = "StatusLbl";
            StatusLbl.Size = new Size(44, 21);
            StatusLbl.TabIndex = 8;
            StatusLbl.Text = "Valid";
            // 
            // ChekpointLbl
            // 
            ChekpointLbl.BackColor = Color.Transparent;
            ChekpointLbl.BorderStyle = BorderStyle.FixedSingle;
            ChekpointLbl.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChekpointLbl.Location = new Point(3, 31);
            ChekpointLbl.Name = "ChekpointLbl";
            ChekpointLbl.Size = new Size(111, 83);
            ChekpointLbl.TabIndex = 7;
            ChekpointLbl.Text = "Checkpoint 009";
            ChekpointLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MatterhornBtn
            // 
            MatterhornBtn.Location = new Point(11, 256);
            MatterhornBtn.Name = "MatterhornBtn";
            MatterhornBtn.Size = new Size(93, 74);
            MatterhornBtn.TabIndex = 6;
            MatterhornBtn.Text = "View Matterhorn Checkpoint";
            MatterhornBtn.UseVisualStyleBackColor = true;
            MatterhornBtn.Click += MatterhornBtn_Click;
            // 
            // ConditionViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 420);
            Controls.Add(groupBox1);
            Controls.Add(ChecksBox);
            Name = "ConditionViewer";
            Text = "Checkpoint Viewer";
            ChecksBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ChecksBox;
        private Button ExitBtn;
        private Button PassChecksBtn;
        private GroupBox groupBox1;
        private Label ChekpointLbl;
        private Button MatterhornBtn;
        private Label StatusLbl;
        private FlowLayoutPanel CheckFlow;
    }
}