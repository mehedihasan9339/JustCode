using System;

namespace _1158_Sum_of_Consecutive_Odd_Numbers_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int n, a, b, sum = 0;

            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                
                inp = Console.ReadLine();
                string[] inpArr = inp.Split(' ');
                a = Convert.ToInt32(inpArr[0]);
                b = Convert.ToInt32(inpArr[1]);
                for (int j = 1; j <= b * 2; j++)
                {
                    if (a % 2 != 0)
                    {
                        sum += a;
                    }
                    a++;
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            
            Console.ReadKey();
        }
    }
}
