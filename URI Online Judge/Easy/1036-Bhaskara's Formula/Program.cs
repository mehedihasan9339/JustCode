using System;

namespace _1036_Bhaskara_s_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            double a, b, c, bac, R1, R2;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            a = Convert.ToDouble(inpArr[0]);
            b = Convert.ToDouble(inpArr[1]);
            c = Convert.ToDouble(inpArr[2]);
            bac = Math.Pow(b, 2) - 4 * a * c;

            if (bac < 0 || (2 * a) == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                R1 = (-b + Math.Sqrt(bac)) / (2 * a);
                R2 = (-b - Math.Sqrt(bac)) / (2 * a);
                Console.WriteLine("R1 = " + R1.ToString("f5"));
                Console.WriteLine("R2 = " + R2.ToString("f5"));
            }

            Console.ReadKey();
        }
    }
}
