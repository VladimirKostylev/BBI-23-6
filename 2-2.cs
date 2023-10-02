using System; 
class Program 
{ 
	static void Main() 
	{ 
    	int sum=1; 
    	int last_sum=0; 
  
    	for (int i=1; i<=10000; i+=3) 
    	{ 
        	sum *=i; 
        	if (sum<=30000) 
        	{ 
            	last_sum=sum; 
        	} 
        	if (sum>30000) 
        	{ 
            	Console.WriteLine(last_sum); 
            	break; 
        	} 
    	} 
	} 
}