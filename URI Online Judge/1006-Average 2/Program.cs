using System;

namespace _1006_Average_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());
            MEDIA = ((A * 2 + B * 3 + C * 5) / (2 + 3 + 5));
            Console.WriteLine("MEDIA = " + MEDIA.ToString("f1"));

            Console.ReadKey();
        }
    }
}
