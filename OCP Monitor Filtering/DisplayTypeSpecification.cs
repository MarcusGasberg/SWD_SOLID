using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class DisplayTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly DisplayType _displayType;

        public DisplayTypeSpecification(DisplayType displayType)
        {
            _displayType = displayType;
        }

        public bool IsSatisfied(ComputerMonitor item) => item.DisplayType == _displayType;
    }
}

