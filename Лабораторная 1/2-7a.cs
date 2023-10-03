using System;

public class Program
{
    public static void Main()
    {
        double S1=10;
        double S2=0;
        double D;
        double k=1.1;
        for (int a=0; a<7; a++)
        {
          D=S1*Math.Pow(k, a);
          S2=S2+D;
        }
                Console.WriteLine(S2);
    }
}