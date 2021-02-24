using System;

namespace GoodDay
{
    class Program
    {
        static void Main()
        {
            Greeting greetiing = new Greeting();
            greetiing.Main();
        }
    }
    public class Greeting
    {
        public void Main()
        {
            Console.WriteLine(value: DateTime.Now.TimeOfDay);
            int hour = DateTime.Now.Hour;

            if (hour > 9 && hour <= 12)
            {
                Console.WriteLine("Good morning, guys!");
            }
            if (hour > 12 && hour <= 15)
            {
                Console.WriteLine("Good day, guys!");
            }
            if (hour > 15 && hour <= 22)
            {
                Console.WriteLine("Good evening, guys!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }
        }
    }

}
