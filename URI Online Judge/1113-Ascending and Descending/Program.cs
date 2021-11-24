using System;

namespace _1113_Ascending_and_Descending
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

                if (x == y)
                {
                    break;
                }
                else
                {
                    if (x < y)
                    {
                        Console.WriteLine("Crescente");
                    }
                    else
                    {
                        Console.WriteLine("Decrescente");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
