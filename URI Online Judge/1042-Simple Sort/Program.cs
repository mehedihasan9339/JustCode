using System;
using System.Linq;

namespace _1042_Simple_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int a, b, c;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            a = Convert.ToInt32(inpArr[0]);
            b = Convert.ToInt32(inpArr[1]);
            c = Convert.ToInt32(inpArr[2]);
            int[] intArr = new int[] { a, b, c };
            int[] newInt = intArr.OrderBy(x => x).ToArray();

            for (int i = 0; i < newInt.Length; i++)
            {
                Console.WriteLine(newInt[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < inpArr.Length; i++)
            {
                Console.WriteLine(inpArr[i]);
            }

            Console.ReadKey();
        }
    }
}
