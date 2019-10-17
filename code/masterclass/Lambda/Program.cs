using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    // A lambda expression is an anonymous function that you can use to create delegates 
    // or expression tree types.By using lambda expressions, you can write local functions 
    // that can be passed as arguments or returned as the value of function calls.Lambda 
    // expressions are particularly helpful for writing LINQ query expressions.
    class Program
    {

        public delegate int SomeMath(int i);
        public delegate bool Compare(int i, Number n);

        static void Main(string[] args)
        {
            DoSomething();
            Console.ReadLine();
        }

        public static void DoSomething()
        {
            // delegate
            SomeMath math = new SomeMath(Square);
            Console.WriteLine(math(8));

            Console.WriteLine("even number with delegate method");
            List<int> list = new List<int> { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
            List<int> eventNumbers = list.FindAll(delegate (int i)
            {
                    return (i % 2 == 0);
            });

            foreach(int even in eventNumbers)
            {
                Console.WriteLine(even);
            }

            // the same but with lambda!!!!! \o/
            Console.WriteLine("odd with lambda");
            List<int> oddNumbers = list.FindAll(i => i % 2 == 1);
            oddNumbers.ForEach(i =>
            {
                Console.WriteLine("Odd Number");
                Console.WriteLine(i);
            });

            math = new SomeMath(x => x * x * x);
            Console.WriteLine(math(3));

            // using Compare delegate , i dont get it yet.

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(5,new Number { n = 5 }));

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Square(int i)
        {
            return i * i;

        }

        public static int TimesTen(int i)
        {
            return i * 10;
        }
    }

    public class Number
    {
        public int n { get; set; }
    }
}
