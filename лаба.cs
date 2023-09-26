using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int n = 1;
            double S = 0;
            double a = 0;
            double e = 0.0001;
            double x = 0;
            do
            {
                a = Math.Cos(n * x) / Math.Pow(n, 2);
                S += a;
                n++;
            }
            while (Math.Abs(a) > e);
            Console.WriteLine(S);
        }
    }
}
