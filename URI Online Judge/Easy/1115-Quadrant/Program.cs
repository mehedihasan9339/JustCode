using System;

namespace _1115_Quadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int x, y;
            while (true)
            {
                inp = Console.ReadLine();
                string[] inpArr = inp.Split(' ');

                x = Convert.ToInt32(inpArr[0]);
                y = Convert.ToInt32(inpArr[1]);

                if (x == 0 || y == 0)
                {
                    break;
                }
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
            }

            Console.ReadKey();
        }
    }
}
