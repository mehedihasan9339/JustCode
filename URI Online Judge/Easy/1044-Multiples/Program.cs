using System;

namespace _1044_Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int a, b;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            a = Convert.ToInt32(inpArr[0]);
            b = Convert.ToInt32(inpArr[1]);
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadKey();
        }
    }
}
