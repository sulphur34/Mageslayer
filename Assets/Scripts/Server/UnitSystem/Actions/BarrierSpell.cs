using Server.GameSystem;

namespace Server
{
    public class BarrierSpell : Spell, IAction
    {
        private Barrier _barrier;

        public BarrierSpell(
            Barrier barrier,
            ITurnInformer turnInformer,
            int rechargeTime,
            int activeTime) : base(turnInformer, rechargeTime, activeTime)
        {
            _barrier = barrier;
        }

        public void Initiate()
        {
            _barrier.Activate();
        }
    }
}