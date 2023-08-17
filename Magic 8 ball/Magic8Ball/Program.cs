using System;
using System.Collections.Generic;

namespace magic_8_Ball
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> responses = new List<string>()
            {
                "Maybe, Maybe not.",
                "Yeah, that's a great idea!",
                "Ask again later, my magic ran out.",
                "NO!",
                "Patience is key, young Padawan.",
                "My sources say no.",
                "Sure, what could go wrong?",
                "What dumb question.",
                "The stars align in your favor, but only if you embrace the unexpected.",
                "Ride the waves of uncertainty, for therein lies your fortune.",
                "Patience, young grasshopper, and the universe shall reveal its secrets.",
                "A twist of fate awaits you at the crossroads of destiny.",
                "Seek not the answers, for they shall find you when the time is ripe.",
                "Fortune favors the curious mind, so explore without hesitation.",
                "The tides of fortune ebb and flow, but your resilience shall prevail.",
                "In the realm of possibilities, your desires shall manifest.",
                "Beware the shadows of doubt, for they obscure the path to success.",
                "A leap of faith shall lead you to the treasures of tomorrow."
            };

            Random rnd = new Random();

            while (true)
            {
                int randomAnswer = rnd.Next(0, responses.Count);
                Console.WriteLine("Please ask a question, my answers are omnipotent.");
                string userInput = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine(responses[randomAnswer]);
                Console.WriteLine("\n");
            }


        }
    }
}
