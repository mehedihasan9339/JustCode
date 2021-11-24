using System;

namespace _1153_Simple_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fact = 1;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);

            Console.ReadKey();
        }
    }
}
