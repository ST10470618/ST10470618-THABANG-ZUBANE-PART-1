using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Chatbot";

            UIHelper.DisplayHeader();
            AudioPlayer.PlayGreeting();
            UIHelper.Divider();

            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}