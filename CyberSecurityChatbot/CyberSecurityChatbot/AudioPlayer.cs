using System;
using System.Media;
using System.IO;

namespace CyberSecurityChatbot
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string path = "Assets/greeting.wav";

                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("Audio file not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}