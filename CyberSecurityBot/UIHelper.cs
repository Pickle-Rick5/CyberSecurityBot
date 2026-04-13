using System;

public class UIHelper
{
    // Main Banner
    public static void ShowLogo()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.WriteLine("║      🔐 CYBERSECURITY AWARENESS BOT         ║");
        Console.WriteLine("╠══════════════════════════════════════════════╣");
        Console.WriteLine("║      Stay Safe • Stay Secure • Stay Smart    ║");
        Console.WriteLine("╚══════════════════════════════════════════════╝");

        Console.ResetColor();
        Console.WriteLine();
    }

    // Section Divider
    public static void ShowDivider()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n──────────────────────────────────────────────\n");
        Console.ResetColor();
    }

    // Styled Message (Bot)
    public static void BotMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🤖 BOT: " + message);
        Console.ResetColor();
    }

    // Styled Input Prompt
    public static void UserPrompt()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("🧑 YOU: ");
        Console.ResetColor();
    }

    // Error Message
    public static void ErrorMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("⚠ " + message);
        Console.ResetColor();
    }
}