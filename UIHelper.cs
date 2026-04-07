using System;


namespace CyberSecurityBot
{
    internal class UIHelper
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"



                                              ██████╗██╗    ██╗██████╗ ███████╗██████╗   
                                            ██╔════╝╚ ██╗  ██╔╝██╔══██╗██╔════╝██╔══██╗ 
                                            ██║       ╚████╔╝  ██████╔╝█████╗  ██████╔╝ 
                                            ██║        ╚██╔╝   ██╔══██╗██╔══╝  ██╔══██╗ 
                                             ╚██████╗   ██║    ██████╔╝███████╗██║  ██║ 
                                              ╚═════╝   ╚═╝    ╚═════╝ ╚══════╝╚═╝  ╚═╝ 

                                                   CYBERSECURITY AWARENESS BOT 
                                                        Stay Safe Online 
");


            Console.ResetColor();
        }
        public static void DispalyMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n\n(¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯)");
            Console.WriteLine("            WELCOME TO CYBERHIELD               ");
            Console.WriteLine("(¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯)");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\n    MENU DISPLAY    ");
            Console.WriteLine("1. Password Safety ");
            Console.WriteLine("2. What is Phishing? ");
            Console.WriteLine("3. Safe Browsing");
            Console.WriteLine("4. The Purpose Of The Bot");
            Console.WriteLine("5. Engage in Casual Communication");
            Console.WriteLine("6. Exit");

            Console.ResetColor();
        }

    }
}
