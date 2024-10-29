namespace Server
{
    public class Regeneration : IContinuousEffect
    {
        private readonly IDamageable _health;
        private readonly int _healValue;

        private bool _isHealing;

        public Regeneration(IDamageable health, int healValue)
        {
            _health = health;
            _healValue = healValue;
        }

        public void Activate()
        {
            _isHealing = true;
        }

        public void Deactivate()
        {
            _isHealing = false;
        }

        public void Apply()
        {
            if(_isHealing)
                _health.TakeDamage(-_healValue);
        }
    }
}