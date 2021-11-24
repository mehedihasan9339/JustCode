using System;

namespace _1159_Sum_of_Consecutive_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            while (true)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                else
                {
                    for (int i = 1; i <= 5 * 2; i++)
                    {
                        if (n % 2 == 0)
                        {
                            sum += n;
                        }
                        n++;
                    }
                    Console.WriteLine(sum);
                    sum = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
