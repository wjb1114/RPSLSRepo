using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameState
    {
        public Player playerOne;
        public Player playerTwo;

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

            do
            {
                GameLoop(playerOne, playerTwo);
            }
            while (playerOne.score < 2 && playerTwo.score < 2);

            if (playerOne.score >= 2)
            {
                Console.WriteLine("Player One wins with " + playerOne.score + " points!");
            }
            else if (playerTwo.score >= 2)
            {
                Console.WriteLine("Player Two wins with " + playerTwo.score + " points!");
            }
        }

        public void GameLoop(Player first, Player second)
        {
            string playerOneMoveStr = "invalid";
            string playerTwoMoveStr = "invalid";
            Console.WriteLine("Player One:");
            do
            {
                playerOneMoveStr = playerOne.GetChoice();
            }
            while (playerOneMoveStr.ToLower() != "rock" && playerOneMoveStr.ToLower() != "paper" && playerOneMoveStr.ToLower() != "scissors" && playerOneMoveStr.ToLower() != "lizard" && playerOneMoveStr.ToLower() != "spock");

            Console.WriteLine("Player Two:");
            do
            {
                playerTwoMoveStr = playerTwo.GetChoice();
            }
            while (playerTwoMoveStr.ToLower() != "rock" && playerTwoMoveStr.ToLower() != "paper" && playerTwoMoveStr.ToLower() != "scissors" && playerTwoMoveStr.ToLower() != "lizard" && playerTwoMoveStr.ToLower() != "spock");

            playerOne.AssignPlayerMove(playerOneMoveStr);
            playerTwo.AssignPlayerMove(playerTwoMoveStr);

            bool playerOneWin = playerOne.GetWinOrLose(playerTwo.move);
            bool playerTwoWin = playerTwo.GetWinOrLose(playerOne.move);

            if (playerOneWin == true && playerTwoWin == false)
            {
                Console.WriteLine("Player One gets a point!");
                playerOne.score++;
            }
            else if (playerOneWin == false && playerTwoWin == true)
            {
                Console.WriteLine("Player Two gets a point!");
                playerTwo.score++;
            }
            else
            {
                Console.WriteLine("There was a draw!");
            }
        }

        public void GetWinner(string moveOne, string moveTwo)
        {
        }

        public void assignObj(string selectedMoveStr)
        {

        }
    }
}
