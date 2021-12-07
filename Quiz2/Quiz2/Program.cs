using System;

namespace Quiz2
{
    public class Building
    {
        private int floors;
        private double area;

        public void setFloors(int floors)
        {
            this.floors = floors;
        }

        public int getFloors()
        {
            return floors;
        }

        public void setArea(double area)
        {
            this.area = area;
        }

        public double getArea()
        {
            return area;
        }
    }

    public class House : Building
    {
        private int bedrooms;
        private int bathrooms;

        public void setBedrooms(int bedrooms)
        {
            this.bedrooms = bedrooms;
        }

        public int getBedrooms()
        {
            return bedrooms;
        }

        public void setBathrooms(int bathrooms)
        {
            this.bathrooms = bathrooms;
        }

        public int getBathrooms()
        {
            return bathrooms;
        }
    }

    public class Office : Building
    {
        private int fireExits;
        private int telephone;

        public void setFireExits(int fireExits)
        {
            this.fireExits = fireExits;
        }

        public int getFireExits()
        {
            return fireExits;
        }

        public void setTelephone(int telephone)
        {
            this.telephone = telephone;
        }

        public int getTelephone()
        {
            return telephone;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House();
            h1.setFloors(5);
            h1.setArea(25.5);
            h1.setBedrooms(6);
            h1.setBathrooms(7);

            Console.WriteLine("Number of Floors : {0}", h1.getFloors());
            Console.WriteLine("Area : {0}", h1.getArea());
            Console.WriteLine("Bedroom on each floor : {0}", h1.getBedrooms());
            Console.WriteLine("Bathroom on each floor : {0}", h1.getBathrooms());

            Console.ReadKey();
        }
    }
}
