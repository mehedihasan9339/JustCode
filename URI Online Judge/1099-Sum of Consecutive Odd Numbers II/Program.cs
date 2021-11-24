using System;

namespace _1099_Sum_of_Consecutive_Odd_Numbers_II
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int a, x, y, sum = 0;
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                inp = Console.ReadLine();
                string[] inpArr = inp.Split(' ');
                x = Convert.ToInt32(inpArr[0]);
                y = Convert.ToInt32(inpArr[1]);

                if (x > y)
                {
                    for (int j = y + 1; j < x; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += j;
                        }
                    }
                    Console.WriteLine(sum);
                    sum = 0;
                }
                else if (x < y)
                {
                    for (int j = x + 1; j < y; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += j;
                        }
                    }
                    Console.WriteLine(sum);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                    Console.WriteLine(sum);
                    sum = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
