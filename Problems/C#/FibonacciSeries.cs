using System;

namespace ConsoleApp1
{
	class FibonacciSeries
	{
		//Enter the number of elements: 6
		//0 1 1 2 3 5
		static void Main(string[] args)
		{
			int n1 = 0, n2 = 1, n3, i, number;
			Console.Write("Enter the number of elements: ");
			number = int.Parse(Console.ReadLine());
			Console.Write(n1 + " " + n2 + " ");
			for (i = 2; i < number; ++i)
			{
				n3 = n1 + n2;
				Console.Write(n3 + " ");
				n1 = n2;
				n2 = n3;
			}
		}
	}
}
