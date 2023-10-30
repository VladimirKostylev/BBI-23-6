using System;

public class Program
{
    public static void Main(string[] args)
    {
     double x = Math.Abs(Double.Parse(Console.ReadLine()));
    double y;
    if (x > 1)
    {
        y = 1;
    }
    else
    {
        y = x;
    }
    Console.WriteLine();
    Console.WriteLine(y);
    }
}