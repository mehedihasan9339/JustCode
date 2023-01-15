using System;

namespace _1070_Six_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
                x++;
            }

            Console.ReadKey();
        }
    }
}
