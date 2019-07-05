using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class LizardMove : PlayerMove
    {
        public LizardMove(string moveName) : base(moveName)
        {

        }

        public override bool GetWinner(PlayerMove opposingMove)
        {
            string opposingName = opposingMove.GiveMoveName();
            if (opposingName == "paper" || opposingName == "spock")
            {
                Console.WriteLine("Lizard beats " + opposingName + "!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
