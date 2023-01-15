using System;

namespace _2313_Which_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int a, b, c;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            a = Convert.ToInt32(inpArr[0]);
            b = Convert.ToInt32(inpArr[1]);
            c = Convert.ToInt32(inpArr[2]);
            if (a + b > c && b + c > a && c + a > b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Valido-Equilatero");
                }
                else
                {
                    if (a != b && b != c && c != a)
                    {
                        Console.WriteLine("Valido-Escaleno");
                    }
                    else
                    {
                        Console.WriteLine("Valido-Isoceles");
                    }
                }
                if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                {
                    Console.WriteLine("Retangulo: S");
                }
                else
                {
                    Console.WriteLine("Retangulo: N");
                }
            }
            else
            {
                Console.WriteLine("Invalido");
            }

            Console.ReadKey();
        }
    }
}
