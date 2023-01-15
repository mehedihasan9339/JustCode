using System;

namespace _1011_Sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, pi = 3.14159;
            R = Convert.ToDouble(Console.ReadLine());
            double volume = (4 / 3.0) * pi * Math.Pow(R, 3);
            Console.WriteLine("VOLUME = " + volume.ToString("f3"));

            Console.ReadKey();
        }
    }
}
