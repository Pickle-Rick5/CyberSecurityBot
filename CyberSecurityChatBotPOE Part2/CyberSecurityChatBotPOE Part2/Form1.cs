namespace CyberSecurityChatBotPOE_Part2
{
    public partial class Form1 : Form
    {
        // stores the last cybersecurity topic the user talked about
        string lastTopic = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // nothing here yet but keeping it in case i need it later
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // textbox event
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // main chatbot logic happens here when user clicks send
        private void btnSend_Click(object sender, EventArgs e)
        {
            // gets what the user typed
            string userInput = textBox2.Text.Trim();

            // converts input to lowercase to make checking easier
            string input = userInput.ToLower();

            // stops empty messages from being sent
            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            // shows user message in the chat area
            richTextBox1.AppendText("You: " + userInput + Environment.NewLine);

            string response = "";

            // sentiment detection section
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

            // password topic with random responses
            else if (input.Contains("password"))
            {
                // remembers last topic
                lastTopic = "password";

                // list of password responses
                string[] passwordResponses =
                {
                    "Use strong unique passwords.",
                    "Avoid using personal information in passwords.",
                    "Change passwords regularly for better security."
                };

                // randomly chooses a response
                Random random = new Random();
                response = passwordResponses[random.Next(passwordResponses.Length)];
            }

            // scam topic
            else if (input.Contains("scam"))
            {
                lastTopic = "scam";
                response = "Avoid suspicious links and messages.";
            }

            // privacy topic
            else if (input.Contains("privacy"))
            {
                lastTopic = "privacy";
                response = "Review your privacy settings regularly.";
            }

            // conversation flow section
            else if (input.Contains("more") || input.Contains("another"))
            {
                // gives extra info depending on previous topic
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

            // default response for unknown inputs
            else
            {
                response = "I do not understand. Can you rephrase?";
            }

            // displays bot response
            richTextBox1.AppendText("Bot: " + response + Environment.NewLine);

            // clears textbox after sending
            textBox2.Clear();
        }
    }
}