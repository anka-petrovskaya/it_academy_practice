using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 32 };
            char[] symbs = new char[] { 'A' };
            string[] txts = new string[] { "Hello" };

            Console.WriteLine("Massive nums:");

            for (int k=0; k<nums.Length; k++)
            {
                Console.Write(nums[k] + " ");
            }
            Console.WriteLine("\nMassive symbs:");

            for (int k = 0; k < symbs.Length; k++)
            {
                Console.Write(symbs[k] + " ");
            }
            Console.WriteLine("\nMassive txts:");

            for (int k = 0; k < txts.Length; k++)
            {
                Console.Write(txts[k] + " ");
            }
            Console.WriteLine();
        }
    }
}
