using System;

namespace _1134_Type_of_Fuel
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, x = 0, y = 0, z = 0;
            while (true)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 4)
                {
                    break;
                }
                else
                {
                    if (a == 1)
                    {
                        x++;
                    }
                    else if (a == 2)
                    {
                        y++;
                    }
                    else if (a == 3)
                    {
                        z++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + x);
            Console.WriteLine("Gasolina: " + y);
            Console.WriteLine("Diesel: " + z);

            Console.ReadKey();
        }
    }
}
