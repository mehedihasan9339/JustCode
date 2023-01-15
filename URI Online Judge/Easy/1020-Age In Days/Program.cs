using System;

namespace _1020_Age_In_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp, y, m, d, rem;
            inp = Convert.ToInt32(Console.ReadLine());
            y = inp / 365;
            rem = inp % 365;
            m = rem / 30;
            rem %= 30;
            d = rem;
            Console.WriteLine(y + " ano(s)");
            Console.WriteLine(m + " mes(es)");
            Console.WriteLine(d + " dia(s)");

            Console.ReadKey();
        }
    }
}
