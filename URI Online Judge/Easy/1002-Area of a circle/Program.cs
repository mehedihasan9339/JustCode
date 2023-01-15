using System;

namespace _1002_Area_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, n = 3.14159, A;
            R = Convert.ToDouble(Console.ReadLine());
            A = n * R * R;
            Console.WriteLine("A=" + A.ToString("f4"));

            Console.ReadKey();
        }
    }
}
