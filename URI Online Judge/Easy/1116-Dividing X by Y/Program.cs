using System;

namespace _1116_Dividing_X_by_Y
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b;
            string inp;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                inp = Console.ReadLine();
                string[] inpArr = inp.Split(' ');
                a = Convert.ToInt32(inpArr[0]);
                b = Convert.ToInt32(inpArr[1]);
                
                if (b != 0)
                {
                    Console.WriteLine((a / Convert.ToDouble(b)).ToString("f1"));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }

            Console.ReadKey();
        }
    }
}
