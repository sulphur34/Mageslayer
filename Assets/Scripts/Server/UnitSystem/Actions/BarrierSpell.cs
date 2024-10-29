using Server.GameSystem;

namespace Server
{
    public class BarrierSpell : Spell, IAction
    {
        private IEffect _barrier;

        public BarrierSpell(
            IEffect barrier,
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