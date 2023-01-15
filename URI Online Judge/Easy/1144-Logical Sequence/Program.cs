using System;

namespace _1144_Logical_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c, d, e, f;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                a = i;
                b = i * i;
                c = i * i * i;
                d = a;
                e = b + 1;
                f = c + 1;
                Console.WriteLine(a + " " + b + " " + c);
                Console.WriteLine(d + " " + e + " " + f);
            }

            Console.ReadKey();
        }
    }
}
