using System;

namespace CyberSecurityChatbot
{
    public class Chatbot
    {
        public string UserName { get; set; }

        public void Start()
        {
            UIHelper.TypeEffect("Hello! What is your name?");
            UserName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(UserName))
            {
                Console.WriteLine("Please enter a valid name:");
                UserName = Console.ReadLine();
            }

            UIHelper.TypeEffect($"Welcome, {UserName}! I'm your Cybersecurity Assistant.");
            UIHelper.Divider();

            ShowMenu(); // ✅ MENU ADDED HERE

            UIHelper.TypeEffect("Type 'menu' anytime to see options again.");

            ChatLoop();
        }

        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nHere’s what you can ask me about:");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Password Safety");
            Console.WriteLine("Phishing Scams");
            Console.WriteLine("Safe Browsing");
            Console.WriteLine("General Help");
            Console.WriteLine("Exit");
            Console.WriteLine("------------------------------------------------");

            Console.ResetColor();
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("⚠️ Please type something.");
                    continue;
                }

                // ✅ SHOW MENU AGAIN IF USER TYPES "menu"
                if (input.Contains("menu"))
                {
                    ShowMenu();
                    continue;
                }

                if (input.Contains("exit"))
                {
                    Console.WriteLine("Goodbye! Stay safe online.");
                    break;
                }

                Respond(input);
            }
        }

        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Bot: ");

            if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm functioning perfectly and ready to keep you safe online!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to educate you about cybersecurity and keep you safe.");
            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("You can ask me about passwords, phishing, and safe browsing.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords with letters, numbers, and symbols. Avoid using personal info.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Phishing is when attackers trick you into giving personal information. Always verify emails.");
            }
            else if (input.Contains("browsing") || input.Contains("links"))
            {
                Console.WriteLine("Avoid clicking suspicious links. Always check the website URL carefully.");
            }
            else
            {
                Console.WriteLine("I didn’t quite understand that. Type 'menu' to see options.");
            }

            Console.ResetColor();
        }
    }
}