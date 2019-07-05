using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class PaperMove : PlayerMove
    {
        public PaperMove(string moveName) : base(moveName)
        {

        }
        public override bool GetWinner(PlayerMove opposingMove)
        {
            string opposingName = opposingMove.GiveMoveName();
            if (opposingName == "spock" || opposingName == "rock")
            {
                Console.WriteLine("Paper beats " + opposingName + "!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
