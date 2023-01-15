using System;

namespace _1041_Coordinates_of_a_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            double x, y;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            x = Convert.ToDouble(inpArr[0]);
            y = Convert.ToDouble(inpArr[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }

            Console.ReadKey();
        }
    }
}
