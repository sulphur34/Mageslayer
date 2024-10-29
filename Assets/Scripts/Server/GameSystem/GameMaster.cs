using System;
using Server.UnitSystem;

namespace Server.GameSystem
{
    public class GameMaster : ITurnInformer
    {
        public event Action TurnOver;

        public void PerformNextTurn()
        {
            TurnOver?.Invoke();
        }
    }
}