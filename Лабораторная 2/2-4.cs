using System;

public class Program
{
    public static void Main(string[] args)
    {
    int n = Int32.Parse(Console.ReadLine());
    double r1 = Double.Parse(Console.ReadLine());
    double r2 = Double.Parse(Console.ReadLine());
    Console.WriteLine();
    int k = 0;
    double x, y, pos;
    for (int i = 0; i < n; i++)
    {
       x = Double.Parse(Console.ReadLine());
       y = Double.Parse(Console.ReadLine());
       Console.WriteLine();
       pos = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
       if (pos >= r1 & pos <= r2) 
       {
           k++;
       }
    }
    Console.WriteLine();
    Console.WriteLine("Точек, попавших в кольцо: " + k);
    }
}