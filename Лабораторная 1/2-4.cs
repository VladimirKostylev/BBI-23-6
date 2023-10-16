using System;

public class Program
{
    public static void Main()
    {
        double x = 0.5;
        double e = 0.0001;
        double sum = 1.0;
        double term = 1.0;
        int n = 2;
        double q = x * x;
        while (Math.Abs(term) >= e)
        {
            sum += term;
            term *= q;
            n += 2;
        }
        Console.WriteLine(sum);
    }
}
