using System;
using System.Speech.Synthesis;

namespace CyberSecurityBot
{
    internal class audioGreetings
    {
        public static void SpeechIntro()
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            string intro = " Greetings, Welcome to cybersecurity awareness bot, I am here to assist you stay safe online. ";
            voice.Speak(intro);
        }
    }
}