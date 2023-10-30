using System;

public class Program
{
    public static void Main(string[] args)
    {
       double x = Double.Parse(Console.ReadLine());
    double y = Double.Parse(Console.ReadLine());
    double r = Double.Parse(Console.ReadLine());
    if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) == r)
    {
        Console.WriteLine("Точка лежит на окружности");
    }
    else
    {
        Console.WriteLine("1) Точка не лежит на окружности");
    }
    }
}