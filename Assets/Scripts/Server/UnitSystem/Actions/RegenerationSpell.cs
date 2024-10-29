using Server.GameSystem;

namespace Server
{
    public class RegenerationSpell : Spell, IAction
    {
        private readonly IEffect _regeneration;

        public RegenerationSpell(
            IEffect regeneration,
            ITurnInformer turnInformer,
            int rechargeTime,
            int activeTime) : base(turnInformer, rechargeTime, activeTime)
        {
            _regeneration = regeneration;
        }

        public void Initiate()
        {
            _regeneration.Activate();
        }
    }
}