using System;

namespace RPSLS
{
    class PaperMove : PlayerMove
    {
        public PaperMove(string moveName) : base(moveName)
        {

        }

        // returns true if wins, returns false otherwise
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
