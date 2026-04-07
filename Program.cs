using System;

namespace CyberSecurityBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            audioGreetings.SpeechIntro();
            UIHelper.DisplayLogo();
            Console.WriteLine("\n Please Enter your name: ");
            string name = Console.ReadLine();
            ChatBot chat = new ChatBot(name);
            chat.Start();

        }
    }
}
