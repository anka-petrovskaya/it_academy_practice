using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, number;
            int size = 13;
            Random rnd = new Random();
            int[] nums = new int[size];
            Console.WriteLine("Массив случайных чисел!");

            for (int k = 0; k < nums.Length; k++)
            {
                nums[k] = (int)('A' + rnd.Next(1,101));
                Console.Write("| " + nums[k] + " ");
            }
            Console.Write("|");
            
            number = 0;
            value = nums[number];

            for (int k = 1; k < nums.Length; k++)
            {
                if (nums[k]>value)
                {
                    value = nums[k];
                    number=k;
                }
            }
            Console.WriteLine("наибольшее значение: " + value);
         } 
    }
}
