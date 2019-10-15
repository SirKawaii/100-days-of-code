using System;
using System.Collections.Generic;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var cars = new List<Car>
            {
                new Audi(200,"blue","A4"),
                new BMW(250,"red","M3")
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            Car bmwz4 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");

            bmwz4.ShowDetails();
            audiA3.ShowDetails();

            BMW bmwz5 = new BMW(330, "white", "Z999");
            bmwz5.ShowDetails();

            Car car8 = (Car)bmwz5;
            car8.ShowDetails();

            Console.ReadLine();
        }
    }

    class Car
    {
        public  int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;

        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: " + " color:" + Color);
           
        }

        public virtual void Repair()
        {
            Console.WriteLine("car was repaired");
        }
    }

    class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }
        public BMW(int hp,string color,string model) : base(hp, color)
        {
            this.Model = model;
        }
        public new void ShowDetails()
        {
            Console.WriteLine("Brand : "+ brand +"HP: " + " color:" + Color);

        }

        public override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired",Color);
        }
    }

    class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Brand : " + brand + "HP: " + " color:" + Color);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Color);
        }
    }
}
