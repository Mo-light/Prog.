Console.WriteLine(" n = ");
int n ;
string s ="schoooff!!!!!!!";
int x=0;

n = Convert.ToInt32(Console.ReadLine());

while (n !=1)
{
    if (n % 2 == 0)
    {  
    n= n/2;
    
        Console.WriteLine(n);
    }
    else
    { 
         Console.WriteLine(s);
    n= n*3 +1;
   
    Console.WriteLine(n);
    x=++x;
    } 

}

Console.WriteLine("Alles gut Brudaaaa" );
Console.WriteLine("Schoofff akam schoofff!!!  ");
Console.WriteLine(x);

