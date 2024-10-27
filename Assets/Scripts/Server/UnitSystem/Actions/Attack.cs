namespace Server
{
    public class Attack : IAction
    {
        private readonly int _damage;
        private readonly IDamageable _target;

        public Attack(int damage, IDamageable target)
        {
            _damage = damage;
            _target = target;
        }

        public void Initiate()
        {
            _target.TakeDamage(_damage);
        }
    }
}