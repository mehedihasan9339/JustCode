using System;

namespace _1145_Logical_Sequence_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int x, y;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            x = Convert.ToInt32(inpArr[0]);
            y = Convert.ToInt32(inpArr[1]);
            if ((1 < x && x < 20) && (x < y && y < 100000))
            {
                for (int i = 1; i <= y; i++)
                {
                    if (i % x != 0)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
