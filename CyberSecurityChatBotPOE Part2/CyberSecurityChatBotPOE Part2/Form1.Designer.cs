namespace CyberSecurityChatBotPOE_Part2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            btnSend = new Button();
            btnAddTask = new Button();
            btnViewTasks = new Button();
            btnActivityLog = new Button();
            btnQuiz = new Button();
            lstTasks = new ListBox();
            lblTasks = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();

            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            //
            // panel1
            //
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 90);

            //
            // pictureBox1
            //
            pictureBox1.Image = Properties.Resources.shield__2_;
            pictureBox1.Location = new Point(20, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(200, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(404, 32);
            lblTitle.Text = "CYBERSECURITY AWARENESS BOT";

            //
            // richTextBox1
            //
            richTextBox1.BackColor = Color.White;
            richTextBox1.Location = new Point(30, 120);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(720, 300);

            //
            // lblTasks
            //
            lblTasks.AutoSize = true;
            lblTasks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTasks.Location = new Point(810, 120);
            lblTasks.Name = "lblTasks";
            lblTasks.Text = "Cyber Tasks";

            //
            // lstTasks
            //
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(780, 160);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(270, 254);

            lstTasks.Items.AddRange(new object[]
            {
                "□ Enable Two-Factor Authentication",
                "□ Review Privacy Settings",
                "□ Change Password"
            });

            //
            // textBox2
            //
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(30, 450);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(550, 27);
            textBox2.TextChanged += textBox2_TextChanged;

            //
            // btnSend
            //
            btnSend.BackColor = Color.RoyalBlue;
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(600, 445);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(120, 40);
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;

            //
            // btnAddTask
            //
            btnAddTask.BackColor = Color.MediumSeaGreen;
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(30, 520);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(150, 40);
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;

            //
            // btnViewTasks
            //
            btnViewTasks.BackColor = Color.MediumSeaGreen;
            btnViewTasks.ForeColor = Color.White;
            btnViewTasks.Location = new Point(220, 520);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(150, 40);
            btnViewTasks.Text = "View Tasks";
            btnViewTasks.UseVisualStyleBackColor = false;

            //
            // btnActivityLog
            //
            btnActivityLog.BackColor = Color.MediumSeaGreen;
            btnActivityLog.ForeColor = Color.White;
            btnActivityLog.Location = new Point(410, 520);
            btnActivityLog.Name = "btnActivityLog";
            btnActivityLog.Size = new Size(150, 40);
            btnActivityLog.Text = "Activity Log";
            btnActivityLog.UseVisualStyleBackColor = false;

            //
            // btnQuiz
            //
            btnQuiz.BackColor = Color.Orange;
            btnQuiz.ForeColor = Color.White;
            btnQuiz.Location = new Point(600, 520);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(150, 40);
            btnQuiz.Text = "Start Quiz";
            btnQuiz.UseVisualStyleBackColor = false;

            //
            // statusStrip1
            //
            statusStrip1.Items.AddRange(new ToolStripItem[]
            {
                toolStripStatusLabel1
            });
            statusStrip1.Location = new Point(0, 620);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1100, 22);

            //
            // toolStripStatusLabel1
            //
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Text = "Ready";

            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1100, 642);
            Controls.Add(statusStrip1);
            Controls.Add(lblTasks);
            Controls.Add(lstTasks);
            Controls.Add(btnQuiz);
            Controls.Add(btnActivityLog);
            Controls.Add(btnViewTasks);
            Controls.Add(btnAddTask);
            Controls.Add(btnSend);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cybersecurity Awareness Bot";
            Load += Form1_Load;

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Button btnSend;
        private Button btnAddTask;
        private Button btnViewTasks;
        private Button btnActivityLog;
        private Button btnQuiz;
        private ListBox lstTasks;
        private Label lblTasks;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}