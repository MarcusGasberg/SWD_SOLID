using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Chores
{
    public static class Factory
    {
        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(),CreateMessageSender());
        }
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
        public static IMessageSender CreateMessageSender()
        {
            return new TextMessageSender();
        }
    }
}
