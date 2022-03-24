using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Singleton
{
    public class Logger
    {
        private string _name;
        private static Dictionary<string, Logger> _loggers = new Dictionary<string, Logger>();
        private Logger(string name)
        {
            _name = name;
        }

        public static Logger GetLogger(string fileName)
        {
            if(!_loggers.ContainsKey(fileName))
                _loggers.Add(fileName, new Logger(fileName));
            return _loggers[fileName];
        }
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
