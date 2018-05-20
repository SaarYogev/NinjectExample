namespace NinjectExample.Base
{
    public class Samurai
    {
        private readonly IWeapon _weapon;

        public Samurai(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack(string enemyName)
        {
            _weapon.Hit(enemyName);
        }
    }
}
