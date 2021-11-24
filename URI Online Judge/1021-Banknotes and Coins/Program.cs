using System;

namespace _1021_Banknotes_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int n100, n50, n20, n10, n5, n2;
            int m1, m50, m25, m10, m05, m01;
            n = Console.ReadLine();
            int notes = Convert.ToInt32(n.Split('.')[0]);
            int coins = Convert.ToInt32(n.Split('.')[1]);

            n100 = notes / 100;
            notes %= 100;
            n50 = notes / 50;
            notes %= 50;
            n20 = notes / 20;
            notes %= 20;
            n10 = notes / 10;
            notes %= 10;
            n5 = notes / 5;
            notes %= 5;
            n2 = notes / 2;
            notes %= 2;

            if (notes < 2)
            {
                coins += notes * 100;
            }

            m1 = coins / 100;
            coins %= 100;
            m50 = coins / 50;
            coins %= 50;
            m25 = coins / 25;
            coins %= 25;
            m10 = coins / 10;
            coins %= 10;
            m05 = coins / 5;
            coins %= 5;
            m01 = coins / 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(n100 + " nota(s) de R$ 100.00");
            Console.WriteLine(n50 + " nota(s) de R$ 50.00");
            Console.WriteLine(n20 + " nota(s) de R$ 20.00");
            Console.WriteLine(n10 + " nota(s) de R$ 10.00");
            Console.WriteLine(n5 + " nota(s) de R$ 5.00");
            Console.WriteLine(n2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(m1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(m01 + " moeda(s) de R$ 0.01");

            Console.ReadKey();
        }
    }
}
