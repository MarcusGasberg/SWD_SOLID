using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Chores
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }

    public class EmailSender : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Send an email to {person.Name} with the message {message}");
        }
    }
    public class TextMessageSender : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Send an text message to {person.Name} with the message {message}");
        }
    }
}
