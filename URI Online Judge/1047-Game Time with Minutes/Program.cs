using System;

namespace _1047_Game_Time_with_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int sh, sm, fh, fm, hour, minute;
            inp = Console.ReadLine();
            string[] inpArr = inp.Split(' ');
            sh = Convert.ToInt32(inpArr[0]);
            sm = Convert.ToInt32(inpArr[1]);
            fh = Convert.ToInt32(inpArr[2]);
            fm = Convert.ToInt32(inpArr[3]);
            hour = fh - sh;
            if (hour <= 0)
            {
                hour += 24;
            }

            minute = fm - sm;
            if (minute < 0)
            {
                minute += 60;
                hour--;
            }

            if (sh == fh && sm == fm)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + hour + " HORA(S) E " + minute + " MINUTO(S)");
            }

            Console.ReadKey();
        }
    }
}
