using System.Dynamic;
using Ninject.Modules;
using Ninject.Parameters;
using NinjectExample.Base;

namespace NinjectExample.Modules
{
    public class SamuraiModules : NinjectModule
    {
        public override void Load()
        {
            dynamic configuration = ConfigurationProvider.Configuration;
            Bind<IWeapon>().To<DartsShooter>().WithConstructorArgument(configuration.dartsMagazineSize.As<byte>());
        }
    }
}
