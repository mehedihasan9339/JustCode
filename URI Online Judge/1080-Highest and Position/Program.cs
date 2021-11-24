using System;

namespace _1080_Highest_and_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = -1, p = 1;
            for (int i = 1; i <= 100; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (max < n)
                {
                    max = n;
                    p = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
