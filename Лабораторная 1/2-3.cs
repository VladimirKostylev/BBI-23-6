using System;
class Program
{
    static void Main(){
        int s=0;
        int n=0;
        int m;
        int a=Convert.ToInt32(Console.ReadLine());
        int h=Convert.ToInt32(Console.ReadLine());
        int p=Convert.ToInt32(Console.ReadLine());
        while (s<=p)
        {
            m=a+n*h;
            s=s+m;
            n++;
        }
        n--;
        Console.WriteLine($"{n:d}");
    }
}