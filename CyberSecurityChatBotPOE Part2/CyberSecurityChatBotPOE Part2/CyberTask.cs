namespace CyberSecurityChatBotPOE_Part2
{
    // stores information about a cybersecurity task
    public class CyberTask
    {
        // title of the task
        public string Title { get; set; }

        // extra information about the task
        public string Description { get; set; }

        // reminder date or message
        public string Reminder { get; set; }

        // checks if the task is finished
        public bool IsCompleted { get; set; }

        // how the task will display in the ListBox
        public override string ToString()
        {
            string status = IsCompleted ? "✔" : "□";
            return status + " " + Title;
        }
    }
}