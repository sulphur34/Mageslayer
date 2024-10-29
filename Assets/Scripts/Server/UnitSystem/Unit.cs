using Unity.VisualScripting;

namespace Server.UnitSystem
{
    public class Unit : IUnitInfo
    {
        public IDamageable Health { get; private set; }
        public IDamageable Barrier { get; private set; }
        public IEffect BarrierEffect { get; private set; }
        public IContinuousEffect Burning { get; private set; }
        public IContinuousEffect Regeneration { get; private set; }

        public Unit(Health health, Barrier barrier, Burning burning, Regeneration regeneration)
        {
            Barrier = barrier;
            BarrierEffect = barrier;
            Health = health;
            Burning = burning;
            Regeneration = regeneration;
        }

        public void ProcessEffects()
        {
            Burning.Apply();
            Regeneration.Apply();
        }
    }
}