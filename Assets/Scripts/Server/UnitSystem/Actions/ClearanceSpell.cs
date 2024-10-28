using Server.GameSystem;

namespace Server
{
    public class ClearanceSpell : Spell, IAction
    {
        private readonly Burning _burning;

        public ClearanceSpell(Burning burning,ITurnInformer turnInformer, int rechargeTime) : base(turnInformer, rechargeTime)
        {
            _burning = burning;
        }

        public void Initiate()
        {
            _burning.Deactivate();
        }
    }
}