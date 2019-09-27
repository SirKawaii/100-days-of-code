using System;
using System.Collections.Generic;
using System.Text;

namespace masterclass
{
    class Human
    {
        // member variable

        private string FirstName { get; set; }
        private string LastName { get; set; }

        private string EyeColor { get; set; }
        private int Age { get; set; }

        // default constructor
        public Human()
        {
            Console.WriteLine("Object created");
        }
        // full human constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EyeColor = eyeColor;
            this.Age = age;
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EyeColor = eyeColor;
        }
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hello, I'm {0}", FirstName);
        }
    }
}
