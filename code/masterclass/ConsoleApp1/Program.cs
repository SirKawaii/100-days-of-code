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
            bmwz4.SetCarIdIndo(53656, "Alfred");
            bmwz4.GetCarIdInfo();

            Car car8 = (Car)bmwz5;
            car8.ShowDetails();

            //M3 mym3 = new M3(250, "red", "M3 super turbo");
            //mym3.Repair();

            Console.ReadLine();
        }
    }

    class Car
    {
        public  int HP { get; set; }
        public string Color { get; set; }

        // has relationship 

        protected CarDiInfo caridIndo = new CarDiInfo();
        public void SetCarIdIndo(int idNum,string owner)
        {
            caridIndo.IDNum = idNum;
            caridIndo.Owner = owner;
        }

        public void GetCarIdInfo()
        {
            Console.WriteLine("the car has no Id of {0} and owned by {1}",this.caridIndo.IDNum, this.caridIndo.Owner);
        }
        public Car()
        {
            // default contstructor
        }

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

    sealed class BMW : Car
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

        public sealed override void Repair()
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

    //class M3 : BMW
    //{
    //    public M3(int hp, string color, string model):base(hp,color,model)
    //    {
    //        this.Model = model;
    //    }

    //    public override void Repair()
    //    {
    //        base.Repair();
    //    }
    //}

    class CarDiInfo
    {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "No Owner";
    }
}
