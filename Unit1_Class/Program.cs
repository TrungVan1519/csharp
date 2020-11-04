using System;

namespace Unit1_Class
{
    class Car
    {
        int passengers;
        float range;

        public int Passenges
        {
            get { return passengers; }
            set { passengers = value; }
        }

        public float Range
        {
            get { return range; }
            set { range = value; }
        }
    }

    class Motorbike
    {
        public int passengers;
        public float range;

        public Motorbike(int passengers, float range)
        {
            this.passengers = passengers;
            this.range = range;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            Motorbike newMotorbike = new Motorbike(2, 3260);
            Motorbike newMotorbike1 = new Motorbike(2, 100);

            newCar.Passenges = 4;
            newCar.Range = 3260F;

            Console.WriteLine("Details of the car:{0, 8}{1, 6}", newCar.Passenges, newCar.Range);
            Console.WriteLine("Details of the motorbike: " + newMotorbike.passengers + "  " + newMotorbike.range);
            Console.WriteLine("Details of the motorbike: " + newMotorbike1.passengers + "  " + newMotorbike1.range);

            Console.ReadKey();
        }
    }
}
