using System;

namespace _1142_PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n * 4; i++)
            {
                if (i % 4 != 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine("PUM");
                }
            }

            Console.ReadKey();
        }
    }
}
