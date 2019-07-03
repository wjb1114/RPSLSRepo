using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AIPlayer : Player
    {
        public Random rand;

        public AIPlayer()
        {
            rand = new Random();
        }
        public override string GetChoice()
        {
            int choiceNum = GetRandomChoice();
            switch (choiceNum)
            {
                case 1:
                    return "rock";
                case 2:
                    return "paper";
                case 3:
                    return "scissors";
                case 4:
                    return "lizard";
                case 5:
                    return "spock";
                default:
                    return "invalid";
            }
        }

        public int GetRandomChoice()
        {
            return rand.Next(1, 6);
        }
    }
}
