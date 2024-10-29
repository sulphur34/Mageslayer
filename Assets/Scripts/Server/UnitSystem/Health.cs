
using System;

namespace Server
{
    public class Health : IDamageable
    {
        private readonly int _minHealth = 0;
        private readonly int _maxValue;

        public Health(int maxValue)
        {
            _maxValue = maxValue;
            Value = _maxValue;
        }

        public int Value { get; private set; }
        public bool IsDead { get; private set; }

        public void TakeDamage(int damage)
        {
            if (!IsDead)
                return;

            Value = Math.Clamp(Value - damage, _minHealth, _maxValue);

            if (Value <= _minHealth)
            {
                IsDead = true;
            }
        }
    }
}