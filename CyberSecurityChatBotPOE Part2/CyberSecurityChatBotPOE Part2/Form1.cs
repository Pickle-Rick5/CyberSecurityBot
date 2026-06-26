namespace CyberSecurityChatBotPOE_Part2
{
    public partial class Form1 : Form
    {
        // remembers the last topic so the bot can answer follow-up questions
        string lastTopic = "";

        // remembers the user's favourite cybersecurity topic
        string favouriteTopic = "";

        // random object used for selecting random responses
        Random random = new Random();

        // stores all the tasks the user creates
        List<CyberTask> tasks = new List<CyberTask>();

        // keeps a log of everything the user does
        List<string> activityLog = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // keeping this here in case i want to add title click features later
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // textbox event, not really needed right now but it can stay
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // main chatbot logic runs when the send button is clicked
        private void btnSend_Click(object sender, EventArgs e)
        {
            // gets the user's message
            string userInput = textBox2.Text.Trim();

            // makes the input lowercase so keyword checking is easier
            string input = userInput.ToLower();

            // stops blank messages from being sent
            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            // shows the user's message in the chat display
            richTextBox1.AppendText("You: " + userInput + Environment.NewLine);

            string response = "";

            // memory feature: remembers the user's favourite topic
            if (input.Contains("interested in"))
            {
                favouriteTopic = userInput.Substring(input.IndexOf("interested in") + 13).Trim();
                lastTopic = favouriteTopic.ToLower();

                response = "Great, I will remember that you are interested in " + favouriteTopic + ".";
            }

            // memory recall feature
            else if (input.Contains("what do you remember") || input.Contains("remember"))
            {
                if (favouriteTopic != "")
                {
                    response = "I remember that you are interested in " + favouriteTopic + ".";
                }
                else
                {
                    response = "I do not have a favourite topic saved for you yet.";
                }
            }

            // sentiment detection section
            else if (input.Contains("worried"))
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
                lastTopic = "password";

                string[] passwordResponses =
                {
                    "Use strong, unique passwords for every account.",
                    "Avoid using personal information like your name or birthday in passwords.",
                    "A password manager can help you create and store secure passwords safely."
                };

                response = passwordResponses[random.Next(passwordResponses.Length)];
            }

            // scam topic with random responses
            else if (input.Contains("scam"))
            {
                lastTopic = "scam";

                string[] scamResponses =
                {
                    "Avoid clicking suspicious links or replying to unknown messages.",
                    "Scammers often create urgency, so always pause and verify first.",
                    "Never share OTP codes, banking details, or passwords with anyone online."
                };

                response = scamResponses[random.Next(scamResponses.Length)];
            }

            // privacy topic with random responses
            else if (input.Contains("privacy"))
            {
                lastTopic = "privacy";

                string[] privacyResponses =
                {
                    "Review your privacy settings regularly on social media accounts.",
                    "Limit the amount of personal information you share online.",
                    "Check app permissions and remove access that is not needed."
                };

                response = privacyResponses[random.Next(privacyResponses.Length)];
            }

            // phishing topic
            else if (input.Contains("phishing"))
            {
                lastTopic = "phishing";

                string[] phishingResponses =
                {
                    "Be careful of emails asking for personal information.",
                    "Check the sender's email address before clicking links.",
                    "Do not download attachments from unknown or suspicious emails."
                };

                response = phishingResponses[random.Next(phishingResponses.Length)];
            }

            // conversation flow for follow-up questions
            else if (input.Contains("more") || input.Contains("another") || input.Contains("explain"))
            {
                if (lastTopic == "password")
                {
                    response = "Another password tip is to enable multi-factor authentication wherever possible.";
                }
                else if (lastTopic == "scam")
                {
                    response = "Another scam tip is to verify messages directly with the company before trusting them.";
                }
                else if (lastTopic == "privacy")
                {
                    response = "For privacy, avoid oversharing your location, phone number, or personal routines online.";
                }
                else if (lastTopic == "phishing")
                {
                    response = "For phishing, always hover over links or inspect them before clicking.";
                }
                else
                {
                    response = "Please ask about a cybersecurity topic first, such as passwords, scams, privacy, or phishing.";
                }
            }

            // default response for unknown inputs
            else
            {
                response = "I am not sure I understand. Please ask about passwords, scams, privacy, phishing, or cybersecurity tips.";
            }

            // displays bot response
            richTextBox1.AppendText("Bot: " + response + Environment.NewLine + Environment.NewLine);

            // clears textbox after sending
            textBox2.Clear();
            textBox2.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskName = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter a cybersecurity task:",
                "Add Task");

            if (taskName == "")
                return;

            CyberTask task = new CyberTask();

            task.Title = taskName;
            task.Description = "Cybersecurity reminder";
            task.Reminder = DateTime.Now.AddDays(1).ToShortDateString();
            task.IsCompleted = false;

            tasks.Add(task);

            lstTasks.Items.Add(task);

            activityLog.Add("Added task: " + task.Title);

            MessageBox.Show("Task added successfully!");
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            lstTasks.Items.Clear();

            foreach (CyberTask task in tasks)
            {
                lstTasks.Items.Add(task);
            }

            activityLog.Add("Viewed tasks.");
        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            string log = "";

            foreach (string item in activityLog)
            {
                log += item + Environment.NewLine;
            }

            MessageBox.Show(log, "Activity Log");
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
                return;

            tasks[lstTasks.SelectedIndex].IsCompleted = true;

            lstTasks.Items.Clear();

            foreach (CyberTask task in tasks)
            {
                lstTasks.Items.Add(task);
            }

            activityLog.Add("Completed task: " +
                            tasks[lstTasks.SelectedIndex].Title);
        }
    }

} 