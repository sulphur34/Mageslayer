using JetBrains.Annotations;
using Server.Data;
using Server.UnitSystem;

namespace Server.GameSystem
{
    public class CompositionRoot
    {
        public void BuildGame()
        {
            var unitData = new UnitData();
            var playerUnit = GetUnit(unitData);
            var enemyUnit = GetUnit(unitData);
            GameMaster gameMaster = new GameMaster();
            var playerActionPerformer = GetActionPerformer(playerUnit, enemyUnit, gameMaster, unitData);
            var enemyActionPerformer = GetActionPerformer(enemyUnit,playerUnit, gameMaster, unitData);
            var playerWizard = new Wizard(playerUnit, playerActionPerformer);
            var enemyWizard = new Wizard(enemyUnit, enemyActionPerformer);
        }

        private Unit GetUnit(UnitData unitData)
        {
            var health = new Health(unitData.HealthValue);
            var barrier = new Barrier(health, unitData.BarrierData.ProtectionValue);
            var burning = new Burning(
                health,
                unitData.FireballData.DamageValue,
                unitData.FireballData.ContinuousDamageValue);
            var regeneration = new Regeneration(health, unitData.RegenerationData.HealthRestoreValue);
            return new Unit (health,barrier,burning,regeneration);
        }

        private ActionPerformer GetActionPerformer(
            Unit wizard,
            Unit enemy,
            ITurnInformer turnInformer,
            UnitData unitData)
        {
            var actionPerformer = new ActionPerformer();
            var attack = new Attack(unitData.AttackData.DamageValue, enemy.Barrier);
            actionPerformer.AddAction(ActionTypes.Attack, attack);
            var barrierSpell = new BarrierSpell(
                wizard.BarrierEffect,
                turnInformer,
                unitData.BarrierData.RechargeTime,
                unitData.BarrierData.ActiveTime);
            actionPerformer.AddAction(ActionTypes.BarrierSpell, barrierSpell);
            var clearanceSpell = new ClearanceSpell(wizard.BarrierEffect,
                turnInformer,
                unitData.ClearanceData.RechargeTime);
            actionPerformer.AddAction(ActionTypes.ClearanceSpell, clearanceSpell);
            var fireballSpell = new FireballSpell(
                enemy.BarrierEffect,
                turnInformer,
                unitData.FireballData.RechargeTime,
                unitData.FireballData.ActiveTime);
            actionPerformer.AddAction(ActionTypes.FireballSpell, fireballSpell);
            var regenerationSpell = new RegenerationSpell(
                wizard.Regeneration,
                turnInformer,
                unitData.RegenerationData.RechargeTime,
                unitData.RegenerationData.ActiveTime);
            actionPerformer.AddAction(ActionTypes.RegenerationSpell, regenerationSpell);
            return actionPerformer;
        }
    }
}