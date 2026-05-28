namespace CyberSecurityChatBotPOE_Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

            private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = textBox2.Text;

            richTextBox1.AppendText("You: " + userInput + Environment.NewLine);

            string response = "";

            if (userInput.ToLower().Contains("password"))
            {
                response = "Use strong unique passwords.";
            }
            else if (userInput.ToLower().Contains("scam"))
            {
                response = "Avoid suspicious links and messages.";
            }
            else if (userInput.ToLower().Contains("privacy"))
            {
                response = "Review your privacy settings regularly.";
            }
            else
            {
                response = "I do not understand. Can you rephrase?";
            }

            richTextBox1.AppendText("Bot: " + response + Environment.NewLine);

            textBox2.Clear();
        }
    }
    }

