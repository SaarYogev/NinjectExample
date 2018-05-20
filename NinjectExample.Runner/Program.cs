using System.Threading;
using Ninject;
using NinjectExample.Base;

namespace NinjectExample.Runner
{
    class Program
    {
        static void Main()
        {
            var kernel = new StandardKernel();
            const string modulesDll = "NinjectExample.Modules.dll";
            kernel.Load(modulesDll);
            var samurai = kernel.Get<Samurai>();
            samurai.Attack("abu bad guy");
            new AutoResetEvent(false).WaitOne();
        }
    }
}
