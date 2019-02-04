using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public static class Program
    {
        public static void Main()
        {
            var devReports = new List<BaseSalaryCalculator>()
            {
                new SeniorDevSalaryCalculator(new DeveloperReport
                        {Id = 1, Name = "Dev1", Level = "Senior Developer", HourlyRate = 30, WorkingHours = 37}),
                new JuniorDevSalaryCalculator(new DeveloperReport
                        {Id = 1, Name = "Dev1", Level = "Junior Developer", HourlyRate = 20, WorkingHours = 37}),
                new SeniorDevSalaryCalculator(new DeveloperReport
                        {Id = 1, Name = "Dev3", Level = "Senior Developer", HourlyRate = 30, WorkingHours = 37})
            };
            var salaryCalculator = new SalaryCalculator(devReports);
            Console.WriteLine($"Sum of all the developer salaries is {salaryCalculator.CalculateTotalSalaries()} dollars");

            Console.ReadKey();
        }
    }
}
