using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Audi:Car
    {
        private string brand = "Audi";

        public string Model { get; set; }

        public Audi()
        {
            Model = "101";
            HP = 1500;
            Color = "Black";
        }

        public Audi(string model, int hp, string color) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: {0}, Model: {1}, HP: {2}cc, Color: {3}", brand, Model, HP, Color);
        }

        public override void Repair()
        {
            Console.WriteLine("Audi {0} was repaired!", Model);
        }
    }
}
