using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class MonitorFilter
    {
        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
            return monitors.Where(m => specification.IsSatisfied(m)).ToList();
        }
    }
}
