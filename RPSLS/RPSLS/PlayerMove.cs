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
