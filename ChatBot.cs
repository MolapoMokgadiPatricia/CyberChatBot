using System;
using System.Threading;

namespace CyberSecurityBot
{
    internal class ChatBot
    {
        string userName;
        public ChatBot(string name)
        {
            userName = name;
        }
        public async void Display(string message)

        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nCyber Bot: ");

            foreach (char text in message)
            { 
                Console.Write(text);
                Thread.Sleep(40);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        public void Start() {

            bool run = true;
            while (run)
            {   
                UIHelper.DispalyMenu();
                Console.Write("Choose Any Option Of Your Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Display("Whenever creating a strong passowrd, you should avoid using obvious information that any person could guess easily. Make sure it contains the following: " + Environment.NewLine + "* Letters (UPPERCASE and lowercasse)" + Environment.NewLine + "* numbers (123etc)" + Environment.NewLine + "* symbols {!@#$}" + Environment.NewLine + "e.g Molapo@21.");                            
                        break;

                    case "2":
                        Display("Phishing is when hackers trick you inro giving them your PERSONAL INFORMATION, like(your passwords or credit card numbers) through fake emails, messages or websites tat look legit.To avoid such scammers, please verify the email from sender if it's a trusted source.");
                        break;
                        
                    case "3":
                        Display("Only visit secure websites that starts with HTTPS and avoid using suspecious links.");
                        break;
                    case "4":
                        Display("I am designed to provide instant support and response to an security related questions.");
                        break;

                    case "5":
                        CasualChat();
                        break;

                    case "6":
                        Display("Thank You and Goodbye "+ userName + " Remember to stay safe online.");
                        run=false;
                        break;

                    default:
                        Display(" INVALID OPTION , PLEASE SELECT AGAIN ");
                        break;

                }
            }
        }
        public void CasualChat()
        {
            Display("You can chat with me, Type 'back' to return to the menu.");
            while (true)
            {
                Console.Write("\n"+userName + ":");
                string input = Console.ReadLine().ToLower();

                if (input.Contains("back"))
                {
                    break;
                }

                else if (input.Contains("hello"))
                {
                    Display(" Hello, How can i assist you");
                }
                else if (input.Contains("how are you"))
                {
                    Display(" I,m a program, programmed to assist you in staying safe online, i don,t have feelings and emotions like a human, but i'm very delighted and happy that i'm helping you with staying safe online. ");
                }
                else if (input.Contains("cybersecurity"))
                {
                    Display(" Cybersecurity is the protection of computer systems, network and sensitive information from unauthorized access. We protect information from hackers, malware and viruses, phishing scams and many more.");
                }
                else if (input.Contains("purpose"))
                {
                    Display(" I am designed to provide instant support and response to an security related questions.");
                }
                else if (input.Contains("software"))
                {
                    Display(" You should update your software regularly, as soon as new updates are available. Here's why:" + Environment.NewLine + "*PATCHES SECURITY VULNERABILITY: Updates often fix security holes that hackers could exploit." + Environment.NewLine + "*FIXES BUGS:Update squash bugs that could cause crashes and data loss." + Environment.NewLine + "*ADDS NEW FEATURES: You'll get new and improved features." + Environment.NewLine + "*PROTECTS AGAINST MALWARE: Updates often includde protects protection from new threats.");
                }
                else if (input.Contains("phishing"))
                {
                    Display(" Phishing is when hackers trick you inro giving them your PERSONAL INFORMATION, like (your passwords or credit card numbers) through fake emails, messages or websites tat look legit. To avoid such scammers, please verify the email from sender if it's a trusted source");
                }
                else if (input.Contains("password"))
                {
                    Display(" Whenever creating a strong passowrd, you should avoid using obvious information that any person could guess easily. Make sure it contains the following: " + Environment.NewLine + "* Letters (UPPERCASE and lowercasse)" + Environment.NewLine + "* numbers (123etc)" + Environment.NewLine + "* symbols {!@#$}" + Environment.NewLine + "e.g Molapo@21.");
                }
                else if (input.Contains("browsing") || input.Contains("browse"))
                {
                    Display(" Only visit secure websites that starts with HTTPS and avaoid using suspecious links.");
                }
                else if (input.Contains("understand")) 
                {
                    Display("I'm glad that you undersatand, do you wish to continue or go back to the main menu.");
                }
                else if (input.Contains("continue"))
                {
                    Display("Ok, what else would you like to know wbout cybersecurity?");
                }
                else
                {
                    Display(" Pardon, i don't understand your question please try again.");
                }
            }   
            
        }
    }

}

