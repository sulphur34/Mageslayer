namespace Server
{
    public class BarrierSpell : IAction
    {
        private Barrier _barrier;

        public BarrierSpell(Barrier barrier)
        {
            _barrier = barrier;
        }

        public void Initiate()
        {
            _barrier.Activate();
        }
    }
}