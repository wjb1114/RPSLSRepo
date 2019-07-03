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

            string playerTwoChoice = "";
            do
            {
                Console.WriteLine("Will the second player be a Human or an AI?");
                playerTwoChoice = Console.ReadLine();
            }
            while (playerTwoChoice.ToLower() != "human" && playerTwoChoice != "ai");

            if (playerOneChoice.ToLower() == "human")
            {
                playerOne = new HumanPlayer();
            }
            else if (playerOneChoice.ToLower() == "ai")
            {
                playerOne = new AIPlayer();
            }

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
        }

        public void GameLoop(Player first, Player second)
        {
            PlayerMove playerOneMove;
            PlayerMove playerTwoMove;
            string playerOneMoveStr = "invalid";
            string playerTwoMoveStr = "invalid";
            Console.WriteLine("Player One:");
            do
            {
                playerOneMoveStr = playerOne.GetChoice();
            }
            while (playerOneMoveStr == "invalid");

            Console.WriteLine("Player Two:");
            do
            {
                playerTwoMoveStr = playerTwo.GetChoice();
            }
            while (playerTwoMoveStr == "invalid");
        }

        public void GetWinner(string moveOne, string moveTwo)
        {
        }

        public void assignObj(string selectedMoveStr)
        {

        }
    }
}
