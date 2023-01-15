using System;

namespace _1072_Interval_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, x, In = 0, Out = 0;
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a >= 10 && a <= 20)
                {
                    In++;
                }
                else
                {
                    Out++;
                }
            }
            Console.WriteLine(In + " in");
            Console.WriteLine(Out + " out");

            Console.ReadKey();
        }
    }
}
