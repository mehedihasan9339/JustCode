using System;

namespace _1038_Snack
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int x, y;
            double price, total;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            x = Convert.ToInt32(inpArr[0]);
            y = Convert.ToInt32(inpArr[1]);
            if (x == 1)
            {
                price = 4.00;
            }
            else if (x == 2)
            {
                price = 4.50;
            }
            else if (x == 3)
            {
                price = 5.00;
            }
            else if (x == 4)
            {
                price = 2.00;
            }
            else
            {
                price = 1.50;
            }
            total = y * price;
            Console.WriteLine("Total: R$ " + total.ToString("f2"));

            Console.ReadKey();
        }
    }
}
