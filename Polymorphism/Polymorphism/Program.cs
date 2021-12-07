using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new BMW("152",1500,"Red"),
                new Audi("100",1200,"Black")
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            Car bmwM4 = new BMW("M4", 2100, "Blue");
            bmwM4.ShowDetails();

            BMW audiA3 = new BMW("A3", 2500, "Green");
            audiA3.ShowDetails();

            bmwM4.SetCarIDInfo(1234, "Bilash");
            audiA3.SetCarIDInfo(1235, "John");

            bmwM4.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            M3 myM3 = new M3(260, "Red", "M3");
            myM3.Repair();

            Console.ReadKey();
        }
    }
}
