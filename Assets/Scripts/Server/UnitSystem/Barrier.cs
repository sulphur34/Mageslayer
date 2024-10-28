namespace Server
{
    public class Barrier : IDamageable, IEffect
    {
        private IDamageable _damageable;
        private int _maxValue;

        public Barrier(IDamageable damageable, int maxValue)
        {
            _damageable = damageable;
            _maxValue = maxValue;
            Value = _maxValue;
        }

        public int Value { get; private set; }
        public bool IsActive { get; set; }

        public void TakeDamage(int damage)
        {
            if (!IsActive)
            {
                _damageable.TakeDamage(damage);
                return;
            }

            if (damage < Value)
            {
                Value -= damage;
                return;
            }

            var reducedDamage = damage - Value;
            Value = 0;
            Deactivate();
            _damageable.TakeDamage(reducedDamage);
        }

        public void Activate()
        {
            IsActive = true;
            Value = _maxValue;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}