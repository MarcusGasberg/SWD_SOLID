using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Chores
{
    public interface ILogger
    {
        void LogMessage(string message);
    }
    class Logger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Logging message: {message}");
        }
    }
}
