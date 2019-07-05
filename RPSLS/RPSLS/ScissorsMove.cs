using System;

namespace RPSLS
{
    class ScissorsMove : PlayerMove
    {
        public ScissorsMove(string moveName) : base(moveName)
        {

        }

        // returns true if wins, returns false otherwise
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
