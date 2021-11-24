using System;

namespace _1048_Salary_Increase
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, total, increse, persent;
            a = Convert.ToDouble(Console.ReadLine());
            if (a > 0 && a <= 400)
            {
                persent = 15;
            }
            else if (a > 400 && a <= 800)
            {
                persent = 12;
            }
            else if (a > 800 && a <= 1200)
            {
                persent = 10;
            }
            else if (a > 1200 && a <= 2000)
            {
                persent = 7;
            }
            else
            {
                persent = 4;
            }
            total = a + a * (persent / 100.00);
            increse = a * (persent / 100.00);
            Console.WriteLine("Novo salario: " + total.ToString("f2"));
            Console.WriteLine("Reajuste ganho: " + increse.ToString("f2"));
            Console.WriteLine("Em percentual: " + persent + " %");

            Console.ReadKey();
        }
    }
}
