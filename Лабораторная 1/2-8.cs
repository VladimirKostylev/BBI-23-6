using System;

public class Program
{
    public static void Main()
    {
        double S=10000;
        for (int k=1; k<=100; k++)
        {
            S*= 1.08;
            if (S >= 20000)
            {
                Console.WriteLine (k);
                break;
            }
        }
    }
}