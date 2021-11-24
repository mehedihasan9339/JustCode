using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1180_Lowest_Number_and_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            
            N = Convert.ToInt32(Console.ReadLine());
            if (N > 1 && N < 1000)
            {
                string inp;
                int[] myArr = new int[N];

                inp = Console.ReadLine();
                string[] inpArr = inp.Split(' ');

                for (int i = 0; i < N; i++)
                {
                    myArr[i] = Convert.ToInt32(inpArr[i]);
                }

                int small = myArr[0];

                foreach (var item in myArr)
                {
                    if (item < small)
                    {
                        small = item;
                    }
                }
                Console.WriteLine("Menor valor: " + small);
                Console.WriteLine("Posicao: " + Array.IndexOf(inpArr, small.ToString()));
            }

            Console.ReadKey();
        }
    }
}
