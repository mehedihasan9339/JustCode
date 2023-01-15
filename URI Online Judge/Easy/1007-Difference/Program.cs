using System;

namespace _1007_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFFERENCE;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());
            DIFFERENCE = (A * B) - (C * D);
            Console.WriteLine("DIFERENCA = " + DIFFERENCE);

            Console.ReadKey();
        }
    }
}
