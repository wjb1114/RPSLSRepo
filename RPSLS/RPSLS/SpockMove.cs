using System;

namespace RPSLS
{
    class SpockMove : PlayerMove
    {
        public SpockMove(string moveName) : base(moveName)
        {

        }

        // returns true if wins, returns false otherwise
        public override bool GetWinner(PlayerMove opposingMove)
        {
            string opposingName = opposingMove.GiveMoveName();
            if (opposingName == "scissors" || opposingName == "rock")
            {
                Console.WriteLine("Spock beats " + opposingName + "!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
