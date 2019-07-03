using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class PlayerMove
    {
        protected string name;

        public PlayerMove(string moveName)
        {
            name = moveName;
        }

        public string GiveMoveName()
        {
            return this.name;
        }

        public abstract bool GetWinner(PlayerMove opposingMove);
    }
}
