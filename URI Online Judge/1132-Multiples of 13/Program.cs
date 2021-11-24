using System;

namespace _1132_Multiples_of_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum = 0;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                    {
                        sum += i;
                    }
                }
            }
            else
            {
                for (int i = y; i <= x; i++)
                {
                    if (i % 13 != 0)
                    {
                        sum += i;
                    }
                }
            }
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
