using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Vehicle
{
    public interface IDrive
    {
        void Drive();
    }
    public interface IFly
    {
        void Fly();
    }

    public class MultiFunctionalCar : IDrive, IFly
    {
        public void Drive() => Console.WriteLine("Driving a MultiFunctionalCar");
        public void Fly() => Console.WriteLine("Flying a MultiFunctionalCar");
    }

    public class Car : IDrive
    {
        public void Drive() => Console.WriteLine("Driving a Car");
    }

    public class Plane : IFly
    {
        public void Fly() => Console.WriteLine("Flying a Plane");
    }
}
