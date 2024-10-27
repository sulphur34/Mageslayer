namespace Server
{
    public interface IDamager
    {
        void InflictDamage(IDamageable damageable, int damage);
    }
}