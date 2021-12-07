using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class BMW:Car
    {
        private string brand = "BMW";

        public string Model { get; set; }

        public BMW()
        {
            Model = "101";
            HP = 1500;
            Color = "Black";
        }

        public BMW(string model, int hp, string color) : base(hp,color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: {0}, Model: {1}, HP: {2}cc, Color: {3}",brand,Model,HP,Color);
        }

        public sealed override void Repair()
        {
            Console.WriteLine("BMW {0} was repaired!", Model);
        }
    }
}
