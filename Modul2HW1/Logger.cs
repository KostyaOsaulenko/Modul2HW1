using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW1
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private StringBuilder _logs = new StringBuilder();

        static Logger()
        {
        }

        private Logger()
        {
            _logs = new StringBuilder();
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public StringBuilder ReturnValueToFile()
        {
            return _logs;
        }

        public void Print(LogTypes types, string message)
        {
            var log = $"{DateTime.UtcNow}: {types}: {message}";
            _logs.AppendLine(log);
            Console.WriteLine(log);
        }
    }
}
