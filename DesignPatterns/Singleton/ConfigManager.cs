using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class ConfigManager
    {
        private Dictionary<string, string> _config = new Dictionary<string, string>();
        private static ConfigManager Instance = new ConfigManager();
        private ConfigManager()
        {
        }

        public void Add(string key, string name) =>
            _config.Add(key, name);

        public void Get(string key)
        {
            Console.WriteLine(_config[key]);

        }

        public static ConfigManager GetInstance() => Instance;
    }
}
