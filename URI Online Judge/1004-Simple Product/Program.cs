using System;

namespace _1004_Simple_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, PROD;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            PROD = A * B;
            Console.WriteLine("PROD = " + PROD);

            Console.ReadKey();
        }
    }
}
