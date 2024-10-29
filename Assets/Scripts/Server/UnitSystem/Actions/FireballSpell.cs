using Server.GameSystem;

namespace Server
{
    public class FireballSpell : Spell, IAction
    {
        private readonly IEffect _burning;

        public FireballSpell(
            IEffect burning,
            ITurnInformer turnInformer,
            int rechargeTime,
            int activeTime) : base(turnInformer, rechargeTime, activeTime)
        {
            _burning = burning;
        }

        public void Initiate()
        {
            _burning.Activate();
        }
    }
}