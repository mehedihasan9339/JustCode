using System;
using System.Linq;

namespace _1045_Triangle_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            double a, b, c;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            a = Convert.ToDouble(inpArr[0]);
            b = Convert.ToDouble(inpArr[1]);
            c = Convert.ToDouble(inpArr[2]);
            double[] dbls = new double[] { a, b, c };
            double[] newArr = dbls.OrderByDescending(x => x).ToArray();
            a = newArr[0];
            b = newArr[1];
            c = newArr[2];

            if (a > 0 && b > 0 && c > 0)
            {
                if (a >= b + c)
                {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                else if (a * a == (b * b + c * c))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (a * a > (b * b + c * c))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (a * a < (b * b + c * c))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if ((a == b && a != c && b != c) || (b == c && b != a && c != a) || (c == a && c != b && a != b))
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

            Console.ReadKey();
        }
    }
}
