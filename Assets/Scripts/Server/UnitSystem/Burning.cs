namespace Server
{
    public class Burning : IContinuousEffect
    {
        private readonly IDamageable _damageable;
        private readonly int _initialDamage;
        private readonly int _damage;

        private bool _isBurning;

        public Burning(IDamageable damageable, int initialDamage, int damage)
        {
            _damageable = damageable;
            _initialDamage = initialDamage;
            _damage = damage;
        }

        public void Activate()
        {
            _isBurning = true;
            _damageable.TakeDamage(_initialDamage);
        }

        public void Deactivate()
        {
            _isBurning = false;
        }

        public void Apply()
        {
            if(_isBurning)
                _damageable.TakeDamage(_damage);
        }
    }
}