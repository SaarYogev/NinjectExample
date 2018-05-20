using System;

namespace NinjectExample.Base
{
    public class DartsShooter : IWeapon
    {
        private readonly byte _dartsMagazineSize;

        public DartsShooter(byte dartsMagazineSize)
        {
            _dartsMagazineSize = dartsMagazineSize;
        }

        public void Hit(string enemyName)
        {
            Console.WriteLine($"You hit {enemyName} with {_dartsMagazineSize} darts");
        }
    }
}