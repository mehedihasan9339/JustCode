using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1929_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int a, b, c, d;

            inp = Console.ReadLine();
            var inpArr = inp.Split(' ');

            a = Convert.ToInt32(inpArr[0]);
            b = Convert.ToInt32(inpArr[1]);
            c = Convert.ToInt32(inpArr[2]);
            d = Convert.ToInt32(inpArr[3]);

            if (a >= 1 && b >= 1 && c >= 1 && d >= 1)
            {
                if (a <= 100 && b <= 100 && c <= 100 && d <= 100)
                {
                    
                }
            }

            Console.ReadKey();
        }
    }
}
