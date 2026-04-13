using System;
using System.Threading;

namespace CyberSecurityChatbot
{
    public class UIHelper
    {
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==== CYBERSECURITY CHATBOT ====");
            Console.WriteLine("[ CYBER SAFE ]");

            Console.ResetColor();
        }

        public static void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        public static void Divider()
        {
            Console.WriteLine("--------------------------------");
        }
    }
}