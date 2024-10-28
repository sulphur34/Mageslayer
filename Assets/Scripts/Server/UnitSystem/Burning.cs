namespace Server
{
    public class Burning : IContinuousEffect
    {
        private IDamageable _damageable;
        private int _damage;
        private bool _isBurning;

        public void Activate()
        {
            _isBurning = true;
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