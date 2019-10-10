using System;
using System.Diagnostics;
using System.Threading;

namespace employes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee victor = new Employee("Victor", "sdfasdfg", 666);

            Boss thatMan = new Boss("Boss", "The",999999999,false);

            Trainees javi = new Trainees("javiera");
            // morning
            WriteSomethingPretty("Morning:");
            thatMan.Lead();
            thatMan.Work();
            victor.Work();
            javi.Learn();
            WriteSomethingPretty("LunchTime:");
            // lunchtime
            thatMan.Pause();
            victor.Pause();
            javi.Pause();
            // evening
            WriteSomethingPretty("Evening:");
            thatMan.Work();
            victor.Work();
            javi.Work();
            // go home!
            WriteSomethingPretty("Go Home:");
            victor.Stop();
            javi.Stop();
            thatMan.Work();
            // ???
            WriteSomethingPretty("At night:");
            thatMan.Stop();

        }
        protected static void WriteSomethingPretty(string thing)
        {
            Console.WriteLine("** {0}",thing);
            Console.WriteLine("*************************");
        }
    }

    class Employee
    {
        protected string Name;
        protected string FirstName;
        protected int Salary;
        protected Timer DoingStuff;
        protected int timeSpend;
        protected bool busy;
        protected int maxWorkingHours;
        protected int TotalWorkingTime;

        public Employee()
        {
            this.Name = String.Empty;
            this.FirstName = String.Empty;
            this.Salary = 0;
            this.timeSpend = 0;
            this.TotalWorkingTime = 0;
            this.maxWorkingHours = 8;
            this.busy = false;
    }
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        public virtual void Work()
        {
            
            if (!busy)
            {
                busy = true;
                Console.WriteLine("{0} is working...",Name);
                DoingStuff = new Timer(DoSomethingCallBack, null, 0, 1000);
            }
            else
            {
                Console.WriteLine("{0} said: Are you kidding me?",Name);
            }
        }
        public void Pause()
        {
            if (busy)
            {
                busy = false;
                Console.WriteLine("{0} is taking coffee...", Name);
                TotalWorkingTime = timeSpend + TotalWorkingTime;
                Stop();
            }
            else
            {
                Console.WriteLine("{0} said: I'm already sleeping.",Name);
            }

        }
        public void Stop() {
            if (busy)
            {
                Console.WriteLine("{0} Stop working.", Name);
                TotalWorkingTime = timeSpend + TotalWorkingTime;
                timeSpend = 0;
                busy = false;
                DoingStuff.Dispose();
            }
            else
            {
                Console.WriteLine("{0} is playing smash bros ultimate.", Name);
            }
        }
        protected void DoSomethingCallBack(Object o)
        {

            if(TotalWorkingTime <= maxWorkingHours)
            {
                timeSpend++;
                TotalWorkingTime = TotalWorkingTime + timeSpend;
                Console.WriteLine("{0} is Working...  {1}s", Name,timeSpend);
                GC.Collect();
            }
            else
            {
                Console.WriteLine("Hey {0} Please go home and rest.", Name);
                Stop();
            }
        }

    }

    class Boss : Employee
    {
        protected bool CompanyCar;
        

        protected Boss() {

            this.CompanyCar = false;
        }

        public Boss(string name, string firstName, int salary, bool car)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            
        }
        public void Lead()
        {
            Console.WriteLine("{0} said: Write some code!!!", Name);
        }

    }

    class Trainees : Employee
    {
        protected int SchoolHourse;

        protected Trainees() { }
        public Trainees(string name)
        {
            this.Name = name;
            this.Salary = 10;
        }
        public void Learn()
        {
            if (!busy)
            {
                busy = true;
                Console.WriteLine("{0} is learning...",Name);
                DoingStuff = new Timer(DoLearning, null, 0, 1000);
            }
            else
            {
                Console.WriteLine("{0} said: I can't learn twice at the same time 😥", Name);
            }
        }

        protected void DoLearning(Object o)
        {
            if (TotalWorkingTime < maxWorkingHours)
            {
                SchoolHourse++;
                TotalWorkingTime = TotalWorkingTime + SchoolHourse;
                Console.WriteLine("Learning...  {0}s", timeSpend);
                GC.Collect();
            }
            else
            {
                Console.WriteLine("{0} need to rest", Name);
                Stop();
            }
        }

        public override void Work()
        {
            if (!busy)
            {
                busy = true;
                Console.WriteLine("{0} is working very hard...", Name);
                DoingStuff = new Timer(DoSomethingCallBack, null, 0, 1000);
            }
            else
            {
                Console.WriteLine("{0} said : I'm feel used.",Name );
            }
        }
    }
}
