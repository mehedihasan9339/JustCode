using System;

namespace _1164_Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, sum = 0;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                for (int j = 1; j < a; j++)
                {
                    if (a % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == a)
                {
                    Console.WriteLine(a + " eh perfeito");
                    sum = 0;
                }
                else
                {
                    Console.WriteLine(a + " nao eh perfeito");
                    sum = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
