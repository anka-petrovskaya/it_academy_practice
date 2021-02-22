using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] objs = new object[3];
            objs[0] = 32;
            objs[1] = 'A';
            objs[2] = "Hello";

            Console.WriteLine("Создан такой массив:");

            for (int k=0; k<objs.Length; k++)
            {
                Console.WriteLine(k + ": " + objs[k]);
            }

            objs[0] = (int)objs[0] + 10;
            objs[2] = "Hello, guys!";

            Console.WriteLine("После присвоения новых значений:");

            for (int k = 0; k < objs.Length; k++)
            {
                Console.WriteLine(k + ": " + objs[k]);
            }
        }
    }
}
