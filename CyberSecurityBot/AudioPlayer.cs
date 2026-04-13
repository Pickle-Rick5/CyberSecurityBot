using System;
using System.Media;

public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greetings.wav");
            player.PlaySync(); // waits until audio finishes
        }
        catch
        {
            Console.WriteLine("⚠ Audio file not found or failed to play.");
        }
    }
}