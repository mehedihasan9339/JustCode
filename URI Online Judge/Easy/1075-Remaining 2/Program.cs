using System;

namespace _1075_Remaining_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 2;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            for (int i = 1; i <= 10000; i++)
            {
                if (i % n == 0)
                {
                    a = i + 2;
                    Console.WriteLine(a);
                }
            }

            Console.ReadKey();
        }
    }
}
