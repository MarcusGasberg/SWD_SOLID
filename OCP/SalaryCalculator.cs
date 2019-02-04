using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerReports;

        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            return _developerReports.Sum(developerReport => developerReport.CalculateSalary());
        }
    }
}

