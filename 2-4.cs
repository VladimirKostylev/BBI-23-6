using System;

public class Program
{
    public static void Main()
    {
        double S1=0;
        double S2=0;
        double x=0.9;
        for (int n=1; n<=10000; n++)
        {
            S1 += Math.Pow(x, n*2);
            if (Math.Pow(x, n*2)>=0.0001)
            {
                S2=S1;
            }
            if (Math.Pow(x, n*2)<0.0001)
            {
                Console.WriteLine(S2);
                break;
            }
        }
    }
}