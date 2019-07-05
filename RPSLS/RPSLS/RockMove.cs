using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RockMove : PlayerMove
    {

        public RockMove(string moveName) : base(moveName)
        {

        }
        public override bool GetWinner(PlayerMove opposingMove)
        {
            string opposingName = opposingMove.GiveMoveName();
            if (opposingName == "scissors" || opposingName == "lizard")
            {
                Console.WriteLine("Rock beats " + opposingName + "!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
