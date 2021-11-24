using System;

namespace _1017_Fuel_Spent
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, s, distance;
            double fuel;
            t = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());

            distance = s * t;
            fuel = (1.0 / 12.0) * distance;

            Console.WriteLine(fuel.ToString("f3"));

            Console.ReadKey();
        }
    }
}
