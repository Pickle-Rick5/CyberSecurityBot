using System;

public class ChatBot
{
    // Ask user for name
    public static string GetUserName()
    {
        Console.Write("\nEnter your name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            return "User";
        }

        return name;
    }

    // Start chatbot loop
    public static void StartChat(string name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nWelcome {name}! I'm here to help you stay safe online.");
        Console.ResetColor();

        while (true)
        {
            Console.Write("\nAsk me something ('exit' to quit): ");
            string input = Console.ReadLine().ToLower();

            // Input validation
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                continue;
            }

            // Exit condition
            if (input == "exit")
            {
                Console.WriteLine($"Goodbye {name}! Stay safe online 👋");
                break;
            }

            Respond(input);
        }
    }

    // Response system
    private static void Respond(string input)
    {
        if (input.Contains("how are you"))
        {
            Console.WriteLine("I'm just a bot, but I'm functioning perfectly!");
        }
        else if (input.Contains("purpose"))
        {
            Console.WriteLine("My purpose is to help you stay safe online.");
        }
        else if (input.Contains("password"))
        {
            Console.WriteLine("Use strong passwords with uppercase, lowercase, numbers, and symbols.");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Phishing is when attackers trick you into giving personal info. Avoid suspicious links.");
        }
        else if (input.Contains("safe browsing"))
        {
            Console.WriteLine("Always use secure websites (https) and avoid unknown downloads.");
        }
        else
        {
            Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
        }
    }
}