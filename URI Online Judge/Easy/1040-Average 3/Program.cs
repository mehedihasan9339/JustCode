using System;

namespace _1040_Average_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            double n1, n2, n3, n4, avg;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            n1 = Convert.ToDouble(inpArr[0]);
            n2 = Convert.ToDouble(inpArr[1]);
            n3 = Convert.ToDouble(inpArr[2]);
            n4 = Convert.ToDouble(inpArr[3]);

            avg = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;
            
            if (avg >= 7.0)
            {
                Console.WriteLine("Media: " + avg.ToString("f1"));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (avg >=5.0 && avg <= 6.9)
            {
                Console.WriteLine("Media: " + avg.ToString("f1"));
                Console.WriteLine("Aluno em exame.");
                double scr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + scr.ToString("f1"));
                double newAvg = (avg + scr) / 2.0;
                if (newAvg >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + newAvg.ToString("f1"));
            }
            else
            {
                Console.WriteLine("Media: " + avg.ToString("f1"));
                Console.WriteLine("Aluno reprovado.");
            }

            Console.ReadKey();
        }
    }
}
