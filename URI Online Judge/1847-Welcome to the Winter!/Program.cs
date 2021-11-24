using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1847_Welcome_to_the_Winter_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            var inp = Console.ReadLine();
            var inpArr = inp.Split(' ');
            a = Convert.ToInt32(inpArr[0]);
            b = Convert.ToInt32(inpArr[1]);
            c = Convert.ToInt32(inpArr[2]);

            if (a > b)
            {
                if (b > c)
                {
                    if ((b - c) < (a - b))
                    {
                        Console.WriteLine(":)");
                    }
                    else
                    {
                        Console.WriteLine(":(");
                    }
                }
                else
                {
                    Console.WriteLine(":)");
                }
            }
            else if (b > a)
            {
                if (c > b)
                {
                    if ((c - b) < (b - a))
                    {
                        Console.WriteLine(":(");
                    }
                    else
                    {
                        Console.WriteLine(":)");
                    }
                }
                else
                {
                    Console.WriteLine(":(");
                }
            }
            else if (c > b)
            {
                Console.WriteLine(":)");
            }
            else
            {
                Console.WriteLine(":(");
            }

            Console.ReadKey();
        }
    }
}
