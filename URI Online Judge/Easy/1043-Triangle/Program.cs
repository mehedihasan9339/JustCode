using System;

namespace _1043_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            double a, b, c, per, trap;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            a = Convert.ToDouble(inpArr[0]);
            b = Convert.ToDouble(inpArr[1]);
            c = Convert.ToDouble(inpArr[2]);
            if (a + b > c && b + c > a && c + a > b)
            {
                per = a + b + c;
                Console.WriteLine("Perimetro = " + per.ToString("f1"));
            }
            else
            {
                trap = ((a + b) / 2) * c;
                Console.WriteLine("Area = " + trap.ToString("f1"));
            }

            Console.ReadKey();
        }
    }
}
