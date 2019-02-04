using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class ScreenTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly ScreenType _screenType;

        public ScreenTypeSpecification(ScreenType screenType)
        {
            _screenType = screenType;
        }

        public bool IsSatisfied(ComputerMonitor item) => item.ScreenType == _screenType;
    }
}
