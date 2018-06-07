using System;
using System.IO;
using YamlDotNet.RepresentationModel;

namespace NinjectExample.Modules
{
    public static class Configuration
    {
        private static readonly YamlMappingNode _rootNode;

        static Configuration()
        {
            var yaml = new YamlStream();
            yaml.Load(new StreamReader(new FileStream("configuration.yml", FileMode.Open)));
            _rootNode = (YamlMappingNode)yaml.Documents[0].RootNode;
        }

        public static T GetValue<T>(string key)
        {
            return _rootNode[key].ToString().As<T>();
        }

        public static TTargetType As<TTargetType>(this object obj)
        {
            try
            {
                return (TTargetType)Convert.ChangeType(obj, typeof(TTargetType));
            }
            catch (InvalidCastException exception)
            {
                Console.WriteLine(exception);
            }

            return default;
        }
    }
}