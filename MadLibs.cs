using System;
using System.Threading;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            while(play) {
                string name = System.String.Empty;
                string firstNoun = System.String.Empty;
                string firstAdjective = System.String.Empty;
                string secondNoun = System.String.Empty;
                string secondAdjective = System.String.Empty;
                string verb = System.String.Empty;

                Console.WriteLine("Welcome to a friendly game of MadLibs!");
                Thread.Sleep(2000);
                Console.WriteLine("\nPlease enter a name:");
                name = Console.ReadLine();
                Console.WriteLine("\nNow enter a noun:");
                firstNoun = Console.ReadLine();
                Console.WriteLine("\nNow enter an adjective:");
                firstAdjective = Console.ReadLine();
                Console.WriteLine("\nNow enter a second noun:");
                secondNoun = Console.ReadLine();
                Console.WriteLine("\nNow enter a second adjective:");
                secondAdjective = Console.ReadLine();
                Console.WriteLine("\nLastly enter a verb:");
                verb = Console.ReadLine();

                Console.WriteLine("\nCreating your sentence...");
                Thread.Sleep(2000);
                Console.WriteLine("\n" + name + " shared a " + firstNoun + " with a/an " + firstAdjective + " " + secondNoun + ". The " + firstNoun + " was even more " + secondAdjective + " than " + name + " had imagined.\nThis was a first for " + name + ", who is used to " + verb + "ing " + secondNoun + "s/es.");
                Thread.Sleep(5000);
                Console.WriteLine("\nThank you for playing my version of MadLibs! Do you want to play again?");

                string playAgain = Console.ReadLine();

                if (playAgain != "yes" && playAgain != "Yes" && playAgain != "y" && playAgain != "Y")
                {
                    play = false;
                }
            }
            Console.WriteLine("\nGoodbye.");
            Thread.Sleep(1000);
        }
    }
}