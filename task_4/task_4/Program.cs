using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            short number = 5;
            object  o = number;

            sbyte number1 = (sbyte)(short)o;
            Console.WriteLine("Variable type: " + number.GetType());
            Console.WriteLine("Variable type: " + number1.GetType());
        }
    }
}
