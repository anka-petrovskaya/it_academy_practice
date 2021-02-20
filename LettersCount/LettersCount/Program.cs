using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter your word");
            string yourword = Console.ReadLine();

            for (int i = 0; i < yourword.Length; ++i)
                   if (yourword[i] == 'a')
                     count++;
      
               Console.WriteLine(count);
        }
    } 
}
