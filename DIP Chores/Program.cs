using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Chores
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.Age = 32;
            owner.Name = "Jens";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Garden Work";
            chore.Owner = owner;
            
            chore.PerformedWork(2.5);
            chore.PerformedWork(4);
            chore.CompleteChore();

            Console.ReadKey();
        }
    }
}
