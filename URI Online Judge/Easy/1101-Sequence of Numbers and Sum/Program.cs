using System;

namespace _1101_Sequence_of_Numbers_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int m, n, sum = 0;
            while (true)
            {
                inp = Console.ReadLine();
                string[] inpArr = inp.Split(' ');

                m = Convert.ToInt32(inpArr[0]);
                n = Convert.ToInt32(inpArr[1]);

                if (m <= 0 || n <= 0)
                {
                    break;
                }
                else
                {
                    if (m > n)
                    {
                        for (int i = n; i <= m; i++)
                        {
                            sum += i;
                            Console.Write(i + " ");
                        }
                        Console.WriteLine("Sum=" + sum);
                        sum = 0;
                    }
                    else if (m < n)
                    {
                        for (int i = m; i <= n; i++)
                        {
                            sum += i;
                            Console.Write(i + " ");
                        }
                        Console.WriteLine("Sum=" + sum);
                        sum = 0;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
