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
            string userInput = textBox2.Text.Trim();
            string input = userInput.ToLower();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            richTextBox1.AppendText("You: " + userInput + Environment.NewLine);

            string response = "";

            if (input.Contains("worried"))
            {
                response = "It is understandable to feel worried. Cybersecurity threats can be stressful, but staying informed helps you stay safe.";
            }
            else if (input.Contains("frustrated"))
            {
                response = "I understand your frustration. Take things step by step and online safety becomes easier to manage.";
            }
            else if (input.Contains("curious"))
            {
                response = "Curiosity is great in cybersecurity. Learning more helps protect you online.";
            }
            else if (input.Contains("password"))
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
            else if (input.Contains("scam"))
            {
                lastTopic = "scam";
                response = "Avoid suspicious links and messages.";
            }
            else if (input.Contains("privacy"))
            {
                lastTopic = "privacy";
                response = "Review your privacy settings regularly.";
            }
            else if (input.Contains("more") || input.Contains("another"))
            {
                if (lastTopic == "password")
                {
                    response = "Consider using a password manager for better security.";
                }
                else if (lastTopic == "scam")
                {
                    response = "Always verify suspicious messages before responding.";
                }
                else if (lastTopic == "privacy")
                {
                    response = "Limit what personal information you share online and review app permissions.";
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