using System;
using System.Media;

public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greetings.wav");
            player.PlaySync(); // allows the ui to wait until audio finishes
        }
        catch
        {
            Console.WriteLine("⚠ Audio file could not be found or failed to play.");
        }
    }
}