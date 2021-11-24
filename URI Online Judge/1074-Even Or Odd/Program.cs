using System;

namespace _1074_Even_Or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (a % 2 == 0)
                {
                    if (a > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                }
                else
                {
                    if (a > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
