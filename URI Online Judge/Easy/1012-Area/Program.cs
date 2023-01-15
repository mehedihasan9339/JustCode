using System;

namespace _1012_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            double a, b, c, recTri, circle, trap, square, rec, pi = 3.14159;
            line = Console.ReadLine();
            a = Convert.ToDouble(line.Split(' ')[0]);
            b = Convert.ToDouble(line.Split(' ')[1]);
            c = Convert.ToDouble(line.Split(' ')[2]);
            
            recTri = 0.5 * a * c;
            circle = pi * Math.Pow(c, 2);
            trap = ((a + b) / 2) * c;
            square = Math.Pow(b, 2);
            rec = a * b;

            Console.WriteLine("TRIANGULO: " + recTri.ToString("f3"));
            Console.WriteLine("CIRCULO: " + circle.ToString("f3"));
            Console.WriteLine("TRAPEZIO: " + trap.ToString("f3"));
            Console.WriteLine("QUADRADO: " + square.ToString("f3"));
            Console.WriteLine("RETANGULO: " + rec.ToString("f3"));

            Console.ReadKey();
        }
    }
}
