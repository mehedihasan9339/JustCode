using System;

namespace _1013_The_Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int a, b, c, majorAB, major;

            a = Convert.ToInt32(inp.Split()[0]);
            b = Convert.ToInt32(inp.Split()[1]);
            c = Convert.ToInt32(inp.Split()[2]);

            majorAB = (a + b + Math.Abs(a - b)) / 2;
            major = (majorAB + c + Math.Abs(majorAB - c)) / 2;

            Console.WriteLine(major + " eh o maior");

            Console.ReadKey();
        }
    }
}
