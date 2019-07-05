using System;

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
            // each player can be human or ai, based on text input
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

            // text input used to determine numer of games to be played
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

            // mian game loop is executed until a player has enough points to win
            do
            {
                GameLoop();
            }
            while (playerOne.GetScore() < numGames && playerTwo.GetScore() < numGames);

            // display winning player alongside their score
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
            // each player makes a choice for what move they will use
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

            // text input from aove step is ues to assign PLayerMOve object to each player
            playerOne.AssignPlayerMove(playerOneMoveStr);
            playerTwo.AssignPlayerMove(playerTwoMoveStr);

            // get win or lose, true is a win, false is a lose or a draw
            bool playerOneWin = playerOne.GetWinOrLose(playerTwo.GetMove());
            bool playerTwoWin = playerTwo.GetWinOrLose(playerOne.GetMove());

            // increment scores based on true/false from GetWinOrLose method
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
                Console.WriteLine("Both players selected " + playerOne.GetMove().GiveMoveName() + "!");
                Console.WriteLine("There was a draw!");
            }

            // display total score for both playes after each round
            Console.WriteLine("Player One has " + playerOne.GetScore() + " points. Player Two has " + playerTwo.GetScore() + " points.");
            Console.ReadKey();
            Console.WriteLine("---------------------------------------------------------");
        }

        // displays instructions when first launching the game application
        public void InitializeText()
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
        }
    }
}
