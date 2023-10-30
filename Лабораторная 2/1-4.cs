using System;

public class Program
{
    public static void Main(string[] args)
    {
      double a = Double.Parse(Console.ReadLine());
    double b = Double.Parse(Console.ReadLine());
    double c = Double.Parse(Console.ReadLine());
    double min, z;
    if (a < b)
    {
        min = a;   
    }
    else
    {
        min = b;
    }
    if (c > min)
    {
        z = c;
    }
    else
    {
        z = min;
    }
    Console.WriteLine();
    Console.WriteLine(z);
    }
}