using System;

class Program
{
    static void Main()
    {
        double a = 0.1;
        double b = 1;
        double h = 0.1;
        double sum = 0;
        double y = 0;
        double last_number = 0;
        int F;
        for (int i = 1; i < 10000; i++)
        {
            F = i;
            for (int n = 1; n <= F; n++)
            {
                F *= n;
            }
            for (double x = a; x <= b; x += h)
            {
                sum += 1 + Math.Cos(i * x) / F;
                y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
                Console.WriteLine($"{sum} {y}");
                last_number = 1 + Math.Cos(i * x) / F;

            }
            if (Math.Abs(last_number) < 0.0001)
            {
                break;
            }
        }
    }
}