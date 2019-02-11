
namespace DIP_Chores
{
    public interface IChore
    {
        string ChoreName { get; set; }
        IPerson Owner { get; set; }
        double HoursWorked { get;}
        bool IsComplete { get; }

        void PerformedWork(double hours);
        void CompleteChore();

    }

    public class Chore : IChore
    {
        private readonly ILogger _logger;
        private readonly IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.LogMessage($"Performed {hours} hours work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            _logger.LogMessage($"Completed {ChoreName}");
            _messageSender.SendMessage(Owner,$"The chore {ChoreName} is complete");
        }
    }
}
