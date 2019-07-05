using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState game = new GameState();
            game.InitializeText();

            // logic is run at least once, and keeps running until input is received to signal the end of the game loop
            bool playAgain = false;
            string playAgainStr = "";
            do
            {
                game = new GameState();
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
