using System;

namespace RPSLS
{
    class HumanPlayer : Player
    {
        public HumanPlayer()
        {

        }

        // player chosses one of five valid choices
        public override string GetChoice()
        {   string playerChoice = "invalid";
            bool isValidChoice = false;
            do
            {
                Console.WriteLine("Please select a move. Your options are \"Rock\", \"Paper\", \"Scissors\", \"Lizard\", and \"Spock\".");
                playerChoice = Console.ReadLine();
                switch (playerChoice.ToLower())
                {
                    case "rock":
                    case "paper":
                    case "scissors":
                    case "lizard":
                    case "spock":
                        isValidChoice = true;
                        break;
                    default:
                        break;                   
                }
            }
            while (isValidChoice == false);
            return playerChoice.ToLower();
        }      
    }
}
