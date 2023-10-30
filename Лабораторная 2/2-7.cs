using System;

public class Program
{
    public static void Main(string[] args)
    {
    int n = Int32.Parse(Console.ReadLine());
    Console.WriteLine();
    int k1 = 0, k3 = 0;
    double x, y;
    for (int i = 0; i < n; i++)
    {
       x = Double.Parse(Console.ReadLine());
       y = Double.Parse(Console.ReadLine());
       if (x == 0 & y == 0)
       {
           Console.WriteLine("Начало координат");
           k1++;
           k3++;
       } 
       else if (x == 0 & y > 0)
       {
           Console.WriteLine("1, 2 квадранты");
           k1++;
       }
       else if (x == 0 & y < 0)
       {
           Console.WriteLine("3, 4 квадранты");
           k3++;
       }
       else if (x > 0 & y == 0)
       {
           Console.WriteLine("1, 4 квадранты");
           k1++;
       }
       else if (x < 0 & y == 0)
       {
           Console.WriteLine("2, 3 квадранты");
           k3++;
       }
       else if (x > 0 & y > 0)
       {
           Console.WriteLine("1 квадрант");
           k1++;
       }
       else if (x < 0 & y > 0)
       {
           Console.WriteLine("2 квадрант");
       }
       else if (x < 0 & y < 0)
       {
           Console.WriteLine("3 квадрант");
           k3++;
       }
       else if (x > 0 & y < 0)
       {
           Console.WriteLine("4 квадрант");
       }
       Console.WriteLine();

    }
    Console.WriteLine();
    Console.WriteLine("Точек в 1 квадранте: " + k1);
    Console.WriteLine("Точек в 3 квадранте: " + k3);
    }
}