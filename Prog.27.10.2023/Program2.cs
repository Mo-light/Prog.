Console.Write("a = ?");
double a = Convert.ToDouble(Console.ReadLine());
double x = (a + 1)/2;
int n = 0;
double tmp = 0;
while(x !=tmp)
{
    n++;
    tmp = x;
    x = 0.5 * (x + a / x);
    Console.WriteLine(x);
}
Console.WriteLine($"Wurzel ({a}) = {x}, nach {n} schritten");