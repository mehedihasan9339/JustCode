using System;

namespace _1005_Average_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            MEDIA = ((A * 3.5 + B * 7.5) / (3.5 + 7.5));
            Console.WriteLine("MEDIA = " + MEDIA.ToString("f5"));

            Console.ReadKey();
        }
    }
}
