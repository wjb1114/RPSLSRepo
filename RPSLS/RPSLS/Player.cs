using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public int score;
        public PlayerMove move;

        public Player()
        {
            score = 0;
        }

        public abstract string GetChoice();

        public PlayerMove AssignPlayerMove (string playerMoveStr)
        {
            PlayerMove playerMove = new RockMove("invalid");
            switch (playerMoveStr)
            {
                case "rock":
                    playerMove =  new RockMove("rock");
                    break;
                case "paper":
                    playerMove = new PaperMove("paper");
                    break;
                case "scissors":
                    playerMove = new ScissorsMove("scissors");
                    break;
                case "lizard":
                    playerMove = new LizardMove("lizard");
                    break;
                case "spock":
                    playerMove = new SpockMove("spock");
                    break;
                default:
                    break;
            }
            move = playerMove;
            return playerMove;
        }

        public bool GetWinOrLose(PlayerMove playerMove)
        {
            return move.GetWinner(playerMove);
        }

    }
}
