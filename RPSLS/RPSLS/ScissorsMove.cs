using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ScissorsMove : PlayerMove
    {
        public ScissorsMove(string moveName) : base(moveName)
        {

        }

        public override bool GetWinner(PlayerMove opposingMove)
        {
            string opposingName = opposingMove.GiveMoveName();
            if (opposingName == "paper" || opposingName == "lizard")
            {
                Console.WriteLine("Scissors beats " + opposingName + "!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
