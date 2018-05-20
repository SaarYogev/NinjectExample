using System;

namespace NinjectExample.Base
{
    public class Shuriken : IWeapon
    {
        public void Hit(string enemyName)
        {
            Console.WriteLine($"You hit {enemyName} in the head");
        }
    }
}