using System;

namespace RPSLS
{
    class RockMove : PlayerMove
    {

        public RockMove(string moveName) : base(moveName)
        {

        }

        // returns true if wins, returns false otherwise
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
