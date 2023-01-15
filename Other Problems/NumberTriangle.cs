﻿using System;

namespace ConsoleApp1
{
	class NumberTriangle
    {
        //Enter the Range=6
        //     1
        //    121
        //   12321
        //  1234321
        // 123454321
        //12345654321
        static void Main(string[] args)
		{
            int i, j, k, l, n;
            Console.Write("Enter the Range=");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");
            }
        }
	}
}
