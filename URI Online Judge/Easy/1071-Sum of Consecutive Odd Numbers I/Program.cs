using System;

namespace _1071_Sum_of_Consecutive_Odd_Numbers_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x == y)
            {
                sum = 0;
            }
            else if(x > y)
            {
                for (int i = y + 1; i < x; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
            }
            else if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    if (i % 2 != 0)
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
