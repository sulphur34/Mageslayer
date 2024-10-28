using Server.GameSystem;

namespace Server
{
    public class FireballSpell : Spell, IAction
    {
        private readonly Burning _burning;
        private readonly IDamageable _damageable;

        public FireballSpell(
            Burning burning,
            IDamageable damageable,
            ITurnInformer turnInformer,
            int rechargeTime,
            int activeTime) : base(turnInformer, rechargeTime, activeTime)
        {
            _burning = burning;
            _damageable = damageable;
        }

        public void Initiate()
        {
            _burning.Activate();
        }
    }
}