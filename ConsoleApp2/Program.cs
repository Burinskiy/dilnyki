using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dil, rez;
            num = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            while (n <= Math.Sqrt(num))
            {
                rez = num % n;
                dil = num / n;
                if (rez == 0)
                {
                    Console.WriteLine(n);
                    if (n != dil)
                    {
                        Console.WriteLine(dil);
                    }
                }
                n++;
            }
            Console.ReadLine();
        }
    }
}
