using System;

namespace masterclass
{
    // noun for classes
    class Program
    {

        // constants as fields;
        const double PI = 3.114159265359;
        const int weeks = 52, months = 12;
        const int days = 365;
        const string birthday = "23-06-1988";
        const string friend = "Connie";


        // Actions verbs 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // try to do

            // Avoid 
            // String myName
            // int32 nyNum

            // Below here are test methods.

            // myBirthday();
            // Convertion();
            // WriteSomething();
            // WriteSomethingSpecific("This is not a print Line method");
            // WriteSomethingSpecific($"The adition of 2 and 5 is:  {Add(Add(100, Multiply(2,2)), 6354)}");
            // Console.WriteLine(GreetFriend(friend));
            //Hello();
            TryHarder();
            Console.ReadKey();
        }
        public static void TryHarder()
        {
            bool enought = false;
            do
            {
                try
                {
                    Console.WriteLine("Please enter a number:");
                    string userInput = Console.ReadLine();
                    int userInputAsInt = int.Parse(userInput);
                    int plusone = userInputAsInt + 1;
                    enought = true;
                    Console.WriteLine($"your number plus 1 is {plusone}, pretty cool, ¿not?");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("I said a NUMBER!!!");
                    Console.WriteLine(e);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("is too big sempai");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("try to write something.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("General exeption my general.");
                    Console.WriteLine(e);
                }
                finally
                {
                    // this always executed.
                    Console.WriteLine("Finally I can rest.");
                }
            }
            while (!enought);
        }
        public static void Hello()
        {
            Console.WriteLine("Please write a friend name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
        public static string GreetFriend(string friendName)
        {
            return $"Hello {friendName}";
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I'm called from a method");
        }
        static void Convertion()
        {
            double myDouble = 13.37;
            int myInt;
            // explicit convertion:
            // this cut the number.
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // Implicit convertion
            int num = 1231654531;
            long bigNum = num;
            float myFloat = 13.37f;
            double myNewFloat = myFloat;

            Console.WriteLine();

            // typeConvertion
            string myStringFloat = myFloat.ToString(); // 13.37;
            Console.WriteLine(myStringFloat);

            // Parsing a string to number 

            string myString = "15";
            string mySecondString = "13";

            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);

            int  result = num1 + num2;

            Console.WriteLine($"The result of {myString} and {mySecondString} is {result.ToString()}");

        }
        static void myBirthday()
        {
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
        }

    }
}
