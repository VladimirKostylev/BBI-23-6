using System;
class Program
{
static void Main()
{
    	int N = Convert.ToInt32(Console.ReadLine());
    	int M = Convert.ToInt32(Console.ReadLine());
    	int K = 0;
    	while (N >= M)
    	{
            K += 1;
            N -= M;
    	}
        Console.WriteLine(K);
    	Console.WriteLine(N);
}
}