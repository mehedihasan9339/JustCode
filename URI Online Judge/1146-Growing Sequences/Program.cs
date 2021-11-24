using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1146_Growing_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else
                {
                    for (int i = 1; i <= a; i++)
                    {
                        if (i != a)
                        {
                            Console.Write(i + " ");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
