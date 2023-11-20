Console.WriteLine("x = ");
double x= Convert.ToDouble(Console.ReadLine());
double summe = 0;
int n = 0;
if (x > 0)
{
    double summand = x;
    while(summand >= 0.0001)
    {
    summe += summand;
    n++;
    summand = x/ Math.Pow(2, n);
    }
Console.WriteLine($"{summe}, {n}");
}
else
{
    Console.WriteLine("Fehler");
}