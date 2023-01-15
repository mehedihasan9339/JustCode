using System;

namespace _1065_Even_Between_Five_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 5; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count + " valores pares");

            Console.ReadKey();
        }
    }
}
