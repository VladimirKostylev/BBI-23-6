using System;

public class Program
{
    public static void Main(string[] args)
    {
    int n = Int32.Parse(Console.ReadLine());
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += Double.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine("Средний рост: " + sum / n);
    }
}