using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Chores
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
    }
    class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
