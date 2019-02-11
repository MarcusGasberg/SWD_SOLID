using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var monitors = new List<ComputerMonitor>()

            { new ComputerMonitor { Name = "Samsung S345", ScreenType = ScreenType.CurvedScreen, DisplayType = DisplayType.OLED },
                new ComputerMonitor { Name = "Philips P532", ScreenType = ScreenType.WideScreen, DisplayType = DisplayType.LCD },
                new ComputerMonitor { Name = "LG L888", ScreenType = ScreenType.WideScreen, DisplayType = DisplayType.LED },
                new ComputerMonitor { Name = "Samsung S999", ScreenType = ScreenType.WideScreen, DisplayType = DisplayType.OLED },
                new ComputerMonitor { Name = "Dell D2J47", ScreenType = ScreenType.CurvedScreen, DisplayType = DisplayType.LCD }
            };

            var filter = new MonitorFilter();
            var lcdMonitors = filter.Filter(monitors, new DisplayTypeSpecification(DisplayType.LCD));

            Console.WriteLine("All LCD monitors");
            foreach (var monitor in lcdMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.DisplayType}, Screen: {monitor.ScreenType}");
            }

            Console.ReadKey();
        }
    }
}
