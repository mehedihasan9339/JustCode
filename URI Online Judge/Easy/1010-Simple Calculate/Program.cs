using System;

namespace _1010_Simple_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            string fLine, lLine;
            int a, b, x, y;
            double c, z, total;
            fLine = Console.ReadLine();
            lLine = Console.ReadLine();

            a = Convert.ToInt32(fLine.Split(' ')[0]);
            b = Convert.ToInt32(fLine.Split(' ')[1]);
            c = Convert.ToDouble(fLine.Split(' ')[2]);
            x = Convert.ToInt32(lLine.Split(' ')[0]);
            y = Convert.ToInt32(lLine.Split(' ')[1]);
            z = Convert.ToDouble(lLine.Split(' ')[2]);
            total = (b * c) + (y * z);
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("f2"));

            Console.ReadKey();
        }
    }
}
