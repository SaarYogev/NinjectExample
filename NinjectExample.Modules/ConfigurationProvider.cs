using System;
using System.Dynamic;
using System.IO;
using YamlDotNet.Serialization;

namespace NinjectExample.Modules
{
    public static class ConfigurationProvider
    {
        public static ExpandoObject Configuration { get; }

        static ConfigurationProvider()
        {
            TextReader input = new StreamReader(new FileStream("configuration.yml", FileMode.Open));
            Configuration = new Deserializer().Deserialize<ExpandoObject>(input);
        }

        public static TTargetType As<TTargetType>(this object obj)
        {
            return (TTargetType)Convert.ChangeType(obj, typeof(TTargetType));
        }
    }
}