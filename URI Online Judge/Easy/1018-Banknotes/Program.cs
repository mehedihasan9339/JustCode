using System;

namespace _1018_Banknotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, rem;
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(a / 100 + " nota(s) de R$ 100,00");
            rem = a % 100;
            Console.WriteLine(rem / 50 + " nota(s) de R$ 50,00");
            rem %= 50;
            Console.WriteLine(rem / 20 + " nota(s) de R$ 20,00");
            rem %= 20;
            Console.WriteLine(rem / 10 + " nota(s) de R$ 10,00");
            rem %= 10;
            Console.WriteLine(rem / 5 + " nota(s) de R$ 5,00");
            rem %= 5;
            Console.WriteLine(rem / 2 + " nota(s) de R$ 2,00");
            rem %= 2;
            Console.WriteLine(rem / 1 + " nota(s) de R$ 1,00");

            Console.ReadKey();
        }
    }
}
