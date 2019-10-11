using System;

namespace Interfaces
{
    public interface INotification
    {
        // members
        void showNotification();
        string getDate();
    }
    public class Notification : INotification
    {
        // TODO: investigate more about this .
        private string sender;
        private string message;
        private string date;

        // Default Constructor.
        public Notification()
        {
            sender = "Admin";
            message = "hello! ";
            date = "";

        }

        public Notification(string mysender, string message, string date)
        {
            this.sender = mysender;
            this.message = message;
            this.date = date;
        }

        public void showNotification()
        {
            Console.WriteLine("Message {0} was sent by {1} at {2}", message , sender,date)
        }
        
        public string getDate()
        {
            return date; ;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Notification n1 = new Notification("Mit", "hello darksnees my old friend", "22:29");
            Notification n2 = new Notification("Voldermort", "Quiero ver cuando el brillo de ojos se apague.","23:30");

            n1.showNotification();
            n2.showNotification();
        }
    }
}
