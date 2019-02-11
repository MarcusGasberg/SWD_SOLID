using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Employee
{
    public enum Gender
    {
        Male,
        Female,
    }

    public enum Position
    {
        Administrator,
        Manager,
        Executive
    }
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }
}
