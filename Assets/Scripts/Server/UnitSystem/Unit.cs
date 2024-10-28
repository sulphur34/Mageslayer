namespace Server.UnitSystem
{
    public class Unit
    {
        private readonly ActionPerformer _actionPerformer;

        public void Act()
        {
            _actionPerformer.Perform();
        }


    }
}