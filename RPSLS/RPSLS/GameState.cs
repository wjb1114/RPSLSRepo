using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameState
    {
        private Player playerOne;
        private Player playerTwo;

        public GameState()
        {
        }

        public void StartGame()
        {
            string playerOneChoice = "";
            do
            {
                Console.WriteLine("Will the first player be a Human or an AI?");
                playerOneChoice = Console.ReadLine();
            }
            while (playerOneChoice.ToLower() != "human" && playerOneChoice != "ai");

            if (playerOneChoice.ToLower() == "human")
            {
                playerOne = new HumanPlayer();
            }
            else if (playerOneChoice.ToLower() == "ai")
            {
                playerOne = new AIPlayer();
            }

            string playerTwoChoice = "";
            do
            {
                Console.WriteLine("Will the second player be a Human or an AI?");
                playerTwoChoice = Console.ReadLine();
            }
            while (playerTwoChoice.ToLower() != "human" && playerTwoChoice != "ai");

            if (playerTwoChoice.ToLower() == "human")
            {
                playerTwo = new HumanPlayer();
            }
            else if (playerTwoChoice.ToLower() == "ai")
            {
                playerTwo = new AIPlayer();
            }

            Console.WriteLine("---------------------------------------------------------");

            int numGames = 0; ;
            string numGamesStr = "";
            bool validInt = false;
            bool errorThrown = false;
            do
            {
                Console.WriteLine("Best of how many games? Must be a positive whole number.");
                numGamesStr = Console.ReadLine();
                try
                {
                    numGames = System.Convert.ToInt32(numGamesStr);
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please enter a valid whole number.");
                    errorThrown = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter a smaller whole number.");
                    errorThrown = true;
                }
                if (numGames % 2 == 1)
                {
                    numGames++;
                }
                numGames /= 2;
                if (numGames < 1 && errorThrown == false)
                {
                    Console.WriteLine("Please enter a whole number greater than zero.");
                }
                else if (errorThrown == true)
                {
                    errorThrown = false;
                }
                else
                {
                    validInt = true;
                    Console.WriteLine("Requires " + numGames + " points to win.");
                    Console.ReadKey();
                }
            }
            while (validInt == false);

            Console.WriteLine("---------------------------------------------------------");

            do
            {
                GameLoop();
            }
            while (playerOne.GetScore() < numGames && playerTwo.GetScore() < numGames);

            if (playerOne.GetScore() >= numGames)
            {
                Console.WriteLine("Player One wins with " + playerOne.GetScore() + " points!");
            }
            else if (playerTwo.GetScore() >= 2)
            {
                Console.WriteLine("Player Two wins with " + playerTwo.GetScore() + " points!");
            }
        }

        private void GameLoop()
        {
            string playerOneMoveStr = "invalid";
            string playerTwoMoveStr = "invalid";
            Console.WriteLine("Player One:");
            do
            {
                playerOneMoveStr = playerOne.GetChoice();
            }
            while (playerOneMoveStr.ToLower() != "rock" && playerOneMoveStr.ToLower() != "paper" && playerOneMoveStr.ToLower() != "scissors" && playerOneMoveStr.ToLower() != "lizard" && playerOneMoveStr.ToLower() != "spock");

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Player Two:");
            do
            {
                playerTwoMoveStr = playerTwo.GetChoice();
            }
            while (playerTwoMoveStr.ToLower() != "rock" && playerTwoMoveStr.ToLower() != "paper" && playerTwoMoveStr.ToLower() != "scissors" && playerTwoMoveStr.ToLower() != "lizard" && playerTwoMoveStr.ToLower() != "spock");

            Console.WriteLine("---------------------------------------------------------");

            playerOne.AssignPlayerMove(playerOneMoveStr);
            playerTwo.AssignPlayerMove(playerTwoMoveStr);

            bool playerOneWin = playerOne.GetWinOrLose(playerTwo.GetMove());
            bool playerTwoWin = playerTwo.GetWinOrLose(playerOne.GetMove());

            if (playerOneWin == true && playerTwoWin == false)
            {
                Console.WriteLine("Player One gets a point!");
                playerOne.IncrementScore();
            }
            else if (playerOneWin == false && playerTwoWin == true)
            {
                Console.WriteLine("Player Two gets a point!");
                playerTwo.IncrementScore();
            }
            else
            {
                Console.WriteLine("There was a draw!");
            }

            Console.WriteLine("Player One has " + playerOne.GetScore() + " points. Player Two has " + playerTwo.GetScore() + " points.");
            Console.ReadKey();
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
