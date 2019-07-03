using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer : Player
    {
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

        public HumanPlayer()
        {

        }
    }
}
