using System;

namespace NinjectExample.Base
{
    public class Katana : IWeapon
    {
        public void Hit(string enemyName)
        {
            Console.WriteLine($"You slash {enemyName} in half");
        }
    }
}