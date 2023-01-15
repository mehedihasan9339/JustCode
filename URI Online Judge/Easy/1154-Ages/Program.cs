using System;

namespace _1154_Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum = 0, count = 0;
            while (true)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                {
                    break;
                }
                else
                {
                    sum += a;
                    count++;
                }
            }
            Console.WriteLine((sum / Convert.ToDouble(count)).ToString("f2"));

            Console.ReadKey();
        }
    }
}
