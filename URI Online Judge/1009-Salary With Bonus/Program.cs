using System;

namespace _1009_Salary_With_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double fs, st, total;
            name = Console.ReadLine();
            fs = Convert.ToDouble(Console.ReadLine());
            st = Convert.ToDouble(Console.ReadLine());
            total = fs + (st * 0.15);
            Console.WriteLine("TOTAL = R$ " + total.ToString("f2"));

            Console.ReadKey();
        }
    }
}
