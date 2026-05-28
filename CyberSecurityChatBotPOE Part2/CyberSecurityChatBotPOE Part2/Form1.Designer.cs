namespace CyberSecurityChatBotPOE_Part2
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
            CybersecurityAwarenessBot = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // CybersecurityAwarenessBot
            // 
            CybersecurityAwarenessBot.AccessibleName = "Title";
            CybersecurityAwarenessBot.AutoSize = true;
            CybersecurityAwarenessBot.BorderStyle = BorderStyle.Fixed3D;
            CybersecurityAwarenessBot.Location = new Point(396, 67);
            CybersecurityAwarenessBot.Margin = new Padding(4, 0, 4, 0);
            CybersecurityAwarenessBot.Name = "CybersecurityAwarenessBot";
            CybersecurityAwarenessBot.Size = new Size(318, 27);
            CybersecurityAwarenessBot.TabIndex = 0;
            CybersecurityAwarenessBot.Text = "CYBERSECURITY AWARENESS BOT";
            // 
            // richTextBox1
            // 
            richTextBox1.AccessibleName = "rtbChat";
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(25, 165);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1026, 213);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, -40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "txtUserInput";
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(350, 413);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(410, 33);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnSend
            // 
            btnSend.AccessibleDescription = "btnSend";
            btnSend.AccessibleName = "btnSend";
            btnSend.Location = new Point(787, 413);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 33);
            btnSend.TabIndex = 4;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1077, 585);
            Controls.Add(btnSend);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(CybersecurityAwarenessBot);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CybersecurityAwarenessBot;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSend;
    }
}
