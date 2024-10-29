namespace Server.UnitSystem
{
    public class Wizard
    {
        public readonly IUnitInfo UnitInfo;
        public readonly IActionPerformer ActionPerformer;

        public Wizard(IUnitInfo unitInfo, ActionPerformer actionPerformer)
        {
            UnitInfo = unitInfo;
            ActionPerformer = actionPerformer;
        }
    }
}