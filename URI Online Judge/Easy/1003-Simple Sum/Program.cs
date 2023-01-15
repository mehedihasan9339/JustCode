using System;

namespace _1003_Simple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, SOMA;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            SOMA = A + B;
            Console.WriteLine("SOMA = " + SOMA);

            Console.ReadKey();
        }
    }
}
