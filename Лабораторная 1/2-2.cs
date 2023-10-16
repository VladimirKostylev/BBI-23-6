using System; 
class Program 
{ 
	static void Main() 
	{ 
    	int sum=1; 
    	int n=1;
	int lim=30000;
		
	while (sum <= lim)
	{
		sum *= n;
		n += 3;
	}
		n -= 3;
		Console.WriteLine(n);
	} 
}
