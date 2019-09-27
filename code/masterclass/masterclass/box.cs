using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace masterclass
{
    class Box
    {
        // inmutable variable.
        private string Color = "Black";
        private int _height;
        private int Lenght;
        // default method to more secure the member variable
        public void SetLenght(int lenght)
        {
            this.Lenght = lenght;
        }
        public int GetLenght()
        {
            return this.Lenght;
        }
        // more simpler version
        private int Height
        {
            get => _height;
            set
            {
                if (value < 0)
                    throw new Exception("Size should be positve");
                else
                    _height =  value;
            }
        }
        // Auto implemented property
        private int Width{ get;set;}

        // the important thing here is the encaptulation.

        public int Volume
        {
            get => (Height * Width * Lenght);
        }

        public Box(int lengh,int width, int height)
        {
            Lenght = lengh;
            Width = width;
            Height = height;
        }
        // public member method
        public void GetBoxData()
        {
            Console.WriteLine("i'm a box of {0} m^2 volume and my color is {1}",Volume, Color);
        }

        // destructor
        ~Box()
        {
            // cleanup  statements
            Debug.Write("Deconstruction of Box object.");
        }

    }
}
