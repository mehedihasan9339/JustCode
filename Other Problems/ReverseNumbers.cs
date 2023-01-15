using System;

namespace ConsoleApp1
{
	class ReverseNumbers
	{
		//Enter a number: 34534
		//Reversed Number: 43543
		static void Main(string[] args)
		{
			int n, reverse = 0, rem;
			Console.Write("Enter a number: ");
			n = int.Parse(Console.ReadLine());
			while (n != 0)
			{
				rem = n % 10;
				reverse = reverse * 10 + rem;
				n /= 10;
			}
			Console.Write("Reversed Number: " + reverse);
		}
	}
}
