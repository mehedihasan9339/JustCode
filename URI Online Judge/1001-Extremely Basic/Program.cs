using System;

namespace _1001_Extremely_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            X = A + B;
            Console.WriteLine("X = " + X);

            Console.ReadKey();
        }
    }
}
