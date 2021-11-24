using System;

namespace _1066_Even__Odd__Positive_and_Negative
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp;
            int even = 0, odd = 0, pos = 0, neg = 0;
            for (int i = 1; i <= 5; i++)
            {
                inp = Convert.ToInt32(Console.ReadLine());
                if (inp >= 0)
                {
                    if (inp == 0)
                    {
                        even++;
                    }
                    else
                    {
                        pos++;
                        if (inp % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
                else
                {
                    neg++;
                    if (inp % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                }
            }
            Console.WriteLine(even + " valor(es) par(es)");
            Console.WriteLine(odd + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");

            Console.ReadKey();
        }
    }
}
