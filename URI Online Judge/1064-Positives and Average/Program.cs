using System;

namespace _1064_Positives_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double inp, count = 0, sum = 0, avg;
            for (int i = 1; i <= 6; i++)
            {
                inp = Convert.ToDouble(Console.ReadLine());
                if (inp > 0)
                {
                    count++;
                    sum += inp;
                }
            }
            avg = sum / count;
            Console.WriteLine(count + " valores positivos");
            Console.WriteLine(avg.ToString("f1"));

            Console.ReadKey();
        }
    }
}
