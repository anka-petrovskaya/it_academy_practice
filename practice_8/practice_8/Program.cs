using System;

namespace practice_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Motocycle motocycle = new Motocycle();
            Motocycle.Engine engine = new Motocycle.Engine();

            Console.WriteLine("Enter the Producer for the motocycle");
            motocycle.producer = Console.ReadLine();
            Console.WriteLine("Enter the Model for the motocycle");
            motocycle.model = Console.ReadLine();
            Console.WriteLine("Enter the number of run kilometers for the motocycle");
            motocycle.numberKm = double.Parse(Console.ReadLine());

            if (motocycle.numberKm >= 100)
            {
                Console.WriteLine("Number of run kilometers should nnot be more than 100!");
            }

            Console.WriteLine("Enter the Size for the motocycle");
            engine.size = int.Parse(Console.ReadLine());

            if (engine.size <= 125 && engine.size >= 3200)
            {
                Console.WriteLine("Your size should be between 125 and 3200");
            }

            Console.WriteLine("Enter the Power for the motocycle");
            engine.power = int.Parse(Console.ReadLine());

            if (engine.power <= 50 && engine.power >= 300)
            {
                Console.WriteLine("Your power should be between 50 and 300");
            }
        }
    }
}