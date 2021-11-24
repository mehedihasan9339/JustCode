using System;

namespace _1015_DistanceBetweenTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp1, inp2;
            double x1, y1, x2, y2, distance;
            inp1 = Console.ReadLine();
            inp2 = Console.ReadLine();

            x1 = Convert.ToDouble(inp1.Split()[0]);
            y1 = Convert.ToDouble(inp1.Split()[1]);
            x2 = Convert.ToDouble(inp2.Split()[0]);
            y2 = Convert.ToDouble(inp2.Split()[1]);

            distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distance.ToString("f4"));

            Console.ReadKey();
        }
    }
}
