using System;
using Ninject.Modules;
using NinjectExample.Base;

namespace NinjectExample.Modules
{
    public class SamuraiModules : NinjectModule
    {
        public override void Load()
        {
            var dartsMagazineSize = Configuration.GetValue<byte>("dartsMagazineSize");
            Bind<IWeapon>().To<DartsShooter>().WithConstructorArgument(Convert.ToByte(dartsMagazineSize));
        }
    }
}
