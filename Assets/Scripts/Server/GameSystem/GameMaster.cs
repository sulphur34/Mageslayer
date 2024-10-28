using System;
using Server.UnitSystem;

namespace Server.GameSystem
{
    public class GameMaster : ITurnInformer
    {
        private Unit _player;
        private Unit _enemy;

        public event Action TurnOver;

        public void PerformNextTurn()
        {
            TurnOver?.Invoke();
        }
    }

    public interface ITurnInformer
    {
        event Action TurnOver;
    }
}