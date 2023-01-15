using System;

namespace _1008_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, h;
            double s, salary;
            e = Convert.ToInt32(Console.ReadLine());
            h = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToDouble(Console.ReadLine());
            salary = h * s;
            Console.WriteLine("NUMBER = " + e);
            Console.WriteLine("SALARY = U$ " + salary.ToString("f2"));

            Console.ReadKey();
        }
    }
}