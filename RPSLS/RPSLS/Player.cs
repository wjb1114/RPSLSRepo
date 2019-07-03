using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        protected int score;
        protected PlayerMove move;

        public Player()
        {
            score = 0;
        }

        public abstract string GetChoice();

        public PlayerMove AssignPlayerMove (string playerMoveStr)
        {
            List<PlayerMove> playerMoves = new List<PlayerMove>();

            playerMoves.Add(new RockMove("rock"));
            playerMoves.Add(new PaperMove("paper"));
            playerMoves.Add(new ScissorsMove("scissors"));
            playerMoves.Add(new LizardMove("lizard"));
            playerMoves.Add(new SpockMove("spock"));

            PlayerMove playerMove = new RockMove("invalid");
            switch (playerMoveStr)
            {
                case "rock":
                    playerMove =  playerMoves[0];
                    break;
                case "paper":
                    playerMove = playerMoves[1];
                    break;
                case "scissors":
                    playerMove = playerMoves[2];
                    break;
                case "lizard":
                    playerMove = playerMoves[3];
                    break;
                case "spock":
                    playerMove = playerMoves[4];
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

        public int GetScore()
        {
            return score;
        }

        public PlayerMove GetMove()
        {
            return move;
        }

        public void IncrementScore()
        {
            score++;
        }
    }
}
