using Server.GameSystem;

namespace Server
{
    public class Spell
    {
        private readonly int _activeTime;
        private readonly int _rechargeTime;
        private readonly ITurnInformer _turnInformer;

        private int _remainActiveTime;
        private int _remainRechargeTime;
        private bool _isActive;

        public Spell(ITurnInformer turnInformer, int rechargeTime = 1, int activeTime = 1)
        {
            _activeTime = activeTime;
            _rechargeTime = rechargeTime;
            _turnInformer = turnInformer;
        }

        protected void StartCast()
        {
            Reset();
            _isActive = true;
            _turnInformer.TurnOver += OnNextTurn;
        }

        protected void EndCast()
        {
            _isActive = false;
        }

        private void OnNextTurn()
        {
            if (!_isActive)
            {
                _remainRechargeTime--;

                if (_remainRechargeTime <= 0)
                    _turnInformer.TurnOver -= OnNextTurn;

                return;
            }

            _remainActiveTime--;

            if(_remainActiveTime <= 0)
                _isActive = false;
        }

        private void Reset()
        {
            _remainActiveTime = _activeTime;
            _remainRechargeTime = _remainRechargeTime;
        }
    }
}