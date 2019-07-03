using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState game = new GameState();

            game.StartGame();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
