using System;

namespace _1037_Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble(Console.ReadLine());

            if (a < 0 || a > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else
            {
                if (a >= 0 && a <= 25)
                {
                    Console.WriteLine("Intervalo [0,25]");
                }
                else if (a > 25 && a <= 50)
                {
                    Console.WriteLine("Intervalo (25,50]");
                }
                else if (a > 50 && a <= 75)
                {
                    Console.WriteLine("Intervalo (50,75]");
                }
                else
                {
                    Console.WriteLine("Intervalo (75,100]");
                }
            }

            Console.ReadKey();
        }
    }
}
