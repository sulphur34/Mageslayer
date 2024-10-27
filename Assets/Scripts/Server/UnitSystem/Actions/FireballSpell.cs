namespace Server
{
    public class FireballSpell
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