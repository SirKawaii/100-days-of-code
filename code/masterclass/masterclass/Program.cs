using System;
using System.Collections;

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

            //myBirthday();
            //Convertion();
            //WriteSomething();
            //WriteSomethingSpecific("This is not a print Line method");
            //WriteSomethingSpecific($"The adition of 2 and 5 is:  {Add(Add(100, Multiply(2,2)), 6354)}");
            //Console.WriteLine(GreetFriend(friend));
            //Hello();
            //TryHarder();
            //Temperature();
            //MyClass();
            //TheBox();
            //TheArrays();
            //MoreArrays();
            int[] studentGrades = new int[]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            //Console.WriteLine("The average of studentGrades is : {0}",GetAverage(studentGrades));
            ArrayList();
            Console.ReadKey();
        }
        public static void ArrayList()
        {
            // declaring arraylist
            ArrayList undefinedArray = new ArrayList();
            ArrayList myArray = new ArrayList(100);

            myArray.Add("34");
            myArray.Add(23);
            myArray.Add("Hello");
            myArray.Add(234);
            myArray.Add(0.666);
            myArray.Add(66000000);

            // delete element at position

            myArray.RemoveAt(0);

            // count

            Console.WriteLine("counnt {0}", myArray.Count);

            double sum = 0;

            foreach(object obj in myArray)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine("sum result {0}", sum);

        }
        public static double GetAverage(int[] gradesArray)
        {

            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
            
        }
        public static void MoreArrays()
        {
            string[][] friendAndFamily = new string[][]
            {
                new string[]{"michaell", "Sandy"},
                new string[]{"Frank", "Claudia" },
                new string[]{"Andrew", "Michelle"}
            };

            foreach(string[] pair in friendAndFamily)
            {
                Console.WriteLine("Hi {0}, i would like to introduce {1} to you", pair[0], pair[1]);
            }
        }
        public static void TheArrays()
        {
            Arrays listas = new Arrays();
            listas.DoSomething();
            listas.DoForeach();
            listas.Multidimensional();
        }
        public static void TheBox()
        {
            Box box = new Box(2, 4, 5);
            box.GetBoxData();
            Box anotherone = new Box(6, 5, 3);
            anotherone.GetBoxData();
        }
        public static void MyClass()
        {
            Human denis = new Human("denis","dow","green",45);
            denis.IntroduceMyself();
            Human karen = new Human("Karen", "denki","black");
            denis.IntroduceMyself();
        }
        public static void Party()
        {
            int age = 25;
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to partyu ");
                    break;
                case 25:
                    Console.WriteLine("Perfection");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }
        public static void Temperature(){
           
            int temperature;
            bool validValue;
            do
            {
                Console.WriteLine("Write the current temperature");
                string temperatureString = Console.ReadLine();
                if (!int.TryParse(temperatureString, out temperature))
                {
                    Console.WriteLine("No temperature has set, here a litle advice:");
                    validValue = false;
                    temperature = 666;
                }
                else
                {
                    validValue = true;
                }
            } while (!validValue);

            if(temperature < 30){
                Console.WriteLine("The temperature is {}",temperature);
            }else{
                Console.WriteLine("Climate change is REAL!!");
            }
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
