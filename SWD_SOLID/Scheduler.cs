using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Scheduler : IEntryManager<SchedulerTask>
    {
        private readonly List<SchedulerTask> _schedulerTasks;

        public Scheduler()
        {
            _schedulerTasks = new List<SchedulerTask>();
        }
        public void AddEntry(SchedulerTask entry) => _schedulerTasks.Add(entry);
        public void RemoveEntryAt(int index) => _schedulerTasks.RemoveAt(index);
        public override string ToString() => string.Join(Environment.NewLine, 
            _schedulerTasks.Select(x => $"Task with id: {x.TaskId} with content: {x.Content} is going to be executed on: {x.ExecuteWhen}"));
    }
}
