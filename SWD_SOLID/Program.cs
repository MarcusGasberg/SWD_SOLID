using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Program
    {
        public static void Main()
        {
            var workReport = new WorkReport();
            workReport.AddEntry(new WorkReportEntry{ProjectCode = "123AB",ProjectName = "SOLID",SpentHours = 4});
            workReport.AddEntry(new WorkReportEntry{ProjectCode = "324CX",ProjectName = "GUIAPP",SpentHours = 65});

            Console.WriteLine(workReport.ToString());

            var scheduler = new Scheduler();
            scheduler.AddEntry(new SchedulerTask{Content = "Alarm",ExecuteWhen = DateTime.Now, TaskId = 200});

            var saver = new FileSaver();
            saver.SaveToFile("home/user/","WorkLogging",workReport);
            saver.SaveToFile("/home/alarms","MorningAlarm",scheduler);
            Console.ReadKey();
        }
    }
}
