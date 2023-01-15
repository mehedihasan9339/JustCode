using System;

namespace _1078_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, result;
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                result = i * a;
                Console.WriteLine(i + " x " + a + " = " + result);
            }

            Console.ReadKey();
        }
    }
}
