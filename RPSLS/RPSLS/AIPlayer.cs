using System;

namespace RPSLS
{
    class AIPlayer : Player
    {
        private Random rand;

        public AIPlayer()
        {
            rand = new Random();
        }

        // Selects 1 of the 5 valid moves using Random()
        public override string GetChoice()
        {
            int choiceNum = GetRandomChoice();
            switch (choiceNum)
            {
                case 1:
                    Console.WriteLine("AI Player selected rock!");
                    Console.ReadKey();
                    return "rock";
                case 2:
                    Console.WriteLine("AI Player selected paper!");
                    Console.ReadKey();
                    return "paper";
                case 3:
                    Console.WriteLine("AI Player selected scissors!");
                    Console.ReadKey();
                    return "scissors";
                case 4:
                    Console.WriteLine("AI Player selected lizard!");
                    Console.ReadKey();
                    return "lizard";
                case 5:
                    Console.WriteLine("AI Player selected spock!");
                    Console.ReadKey();
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
