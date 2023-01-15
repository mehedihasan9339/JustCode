using System;

namespace _1019_Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp, h, m, s, rem;
            inp = Convert.ToInt32(Console.ReadLine());
            h = inp / 3600;
            rem = inp % 3600;
            m = rem / 60;
            rem %= 60;
            s = rem;
            Console.WriteLine(h + ":" + m + ":" + s);

            Console.ReadKey();
        }
    }
}
