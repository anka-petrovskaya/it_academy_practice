using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 10, k;
            int[] nums = new int[size];
            Console.WriteLine("Массив случайных чисел!");

            for (k = 0; k < nums.Length; k++)
            {
                nums[k] = (int)('A' + rnd.Next(26));
                Console.Write("| " + nums[k] + " ");
            }
            Console.Write("|");

            Console.WriteLine();
            int value, number;
            number = 0;
            value = nums[number];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i]>value)
                {
                    value = nums[k];
                    number k;

                }
            }
            Console.WriteLine("наибольшее значение: " + value);
         } 
    }
}
