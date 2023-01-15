using System;

namespace ConsoleApp1
{
	class Program
	{
        //Enter a number: 254856
        //Sum is= 30
		static void Main(string[] args)
		{
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);
        }
	}
}
