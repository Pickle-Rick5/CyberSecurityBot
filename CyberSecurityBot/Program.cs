using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        UIHelper.ShowLogo();              // Shows the ASCII logo
        AudioPlayer.PlayGreeting();       // Plays my voice greeting

        string name = ChatBot.GetUserName();  // Asks for user name
        ChatBot.StartChat(name);              // Starts the chatbot
    }
}