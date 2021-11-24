using System;

namespace _1035_Selection_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int A, B, C, D;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            A = Convert.ToInt32(inpArr[0]);
            B = Convert.ToInt32(inpArr[1]);
            C = Convert.ToInt32(inpArr[2]);
            D = Convert.ToInt32(inpArr[3]);

            if ((B > C) && (D > A) && ((C + D) > (A + B)) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
            Console.ReadKey();
        }
    }
}
