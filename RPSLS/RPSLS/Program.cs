using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for playing \"Rock Paper Scissors Lizard Spock\"!");
            Console.WriteLine("The rules are simple. You pick an action, and so does your oppenent.\nEach action either beats or is defeated by every other action.");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("---------------------------------------------------------");

            bool playAgain = false;
            string playAgainStr = "";
            do
            {
                GameState game = new GameState();
                game.StartGame();
                do
                {
                    Console.WriteLine("Would you like to play again? Enter \"Yes\" or \"No\"");
                    playAgainStr = Console.ReadLine();
                }
                while (playAgainStr.ToLower() != "yes" && playAgainStr.ToLower() != "no");
                if (playAgainStr.ToLower() == "yes")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

                Console.WriteLine("---------------------------------------------------------");
            }
            while (playAgain == true);           

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
