namespace CyberSecurityChatBotPOE_Part2
{
    public partial class Form1 : Form
    {
        string lastTopic = "";
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
                lastTopic = "password";

                string[] passwordResponses =
                {
                "Use strong unique passwords.",
                "Avoid using personal information in passwords.",
                "Change passwords regularly for better security."
                };

                Random random = new Random();

                response = passwordResponses[random.Next(passwordResponses.Length)];
            }
            else if (userInput.ToLower().Contains("scam"))
            {
                response = "Avoid suspicious links and messages.";
            }
            else if (userInput.ToLower().Contains("privacy"))
            {
                response = "Review your privacy settings regularly.";
            }
            else if (userInput.ToLower().Contains("more") || userInput.ToLower().Contains("another"))
            {
                if (lastTopic == "password")
                {
                    response = "Consider using a password manager for better security.";
                }
                else if (lastTopic == "scam")
                {
                    response = "Always verify suspicious messages before responding.";
                }
                else
                {
                    response = "Please ask about a cybersecurity topic first.";
                }
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

