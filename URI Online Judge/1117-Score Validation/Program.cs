using System;

namespace _1117_Score_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, sum = 0;
            int count = 0;
            
            while (true)
            {
                a = Convert.ToDouble(Console.ReadLine());
                if (a >= 0 && a <= 10)
                {
                    sum += a;
                    count++;
                    if (count == 2)
                    {
                        Console.WriteLine("media = " + sum / 2);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            Console.ReadKey();
        }
    }
}
