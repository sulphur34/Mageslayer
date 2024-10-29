using Server.UnitSystem;

namespace Server.Data
{
    public class UnitData
    {
        public int HealthValue { get; } = 10;
        public AttackData AttackData { get; }
        public BarrierData BarrierData { get; }
        public ClearanceData ClearanceData { get; }
        public FireballData FireballData { get; }
        public RegenerationData RegenerationData { get; }

        public UnitData()
        {
            AttackData = new AttackData();
            BarrierData = new BarrierData();
            ClearanceData = new ClearanceData();
            FireballData = new FireballData();
            RegenerationData = new RegenerationData();
        }
    }
}