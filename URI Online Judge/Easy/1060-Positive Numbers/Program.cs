using System;

namespace _1060_Positive_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double inp, count = 0;
            for (int i = 1; i <= 6; i++)
            {
                inp = Convert.ToDouble(Console.ReadLine());
                if (inp > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count + " valores positivos");

            Console.ReadKey();
        }
    }
}
