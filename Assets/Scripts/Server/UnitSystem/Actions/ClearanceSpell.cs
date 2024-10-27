namespace Server
{
    public class ClearanceSpell : IAction
    {
        private readonly Burning _burning;

        public ClearanceSpell(Burning burning)
        {
            _burning = burning;
        }

        public void Initiate()
        {
            _burning.Deactivate();
        }
    }
}