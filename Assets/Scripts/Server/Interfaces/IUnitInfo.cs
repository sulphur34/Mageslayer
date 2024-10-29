namespace Server.UnitSystem
{
    public interface IUnitInfo
    {
        public IDamageable Health { get; }

        public IDamageable Barrier { get; }

        public IEffect BarrierEffect { get; }
        public IContinuousEffect Burning { get; }
        public IContinuousEffect Regeneration { get; }
    }
}