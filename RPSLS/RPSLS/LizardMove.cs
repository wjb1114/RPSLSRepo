using System;

namespace RPSLS
{
    class LizardMove : PlayerMove
    {
        public LizardMove(string moveName) : base(moveName)
        {

        }

        // returns true if wins, returns false otherwise
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
