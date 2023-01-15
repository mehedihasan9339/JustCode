using System;

namespace _1046_Game_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int a, b, duration;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            a = Convert.ToInt32(inpArr[0]);
            b = Convert.ToInt32(inpArr[1]);
            duration = b - a;
            if (duration < 0)
            {
                duration = (24 - a) + b;
                Console.WriteLine("O JOGO DUROU " + duration + " HORA(S)");
            }
            else if (a == b)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU " + duration + " HORA(S)");
            }

            Console.ReadKey();
        }
    }
}
