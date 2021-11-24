using System;

namespace _1143_Squared_and_Cubic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                a = i;
                b = i * i;
                c = i * i * i;
                Console.WriteLine(a + " " + b + " " + c);
            }

            Console.ReadKey();
        }
    }
}
