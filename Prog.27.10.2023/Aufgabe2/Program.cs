int n = Convert.ToInt32(Console.ReadLine());
for (int start = n ; start >=2; start--)
{
    int summe = 0;
    int i = start;
    while(summe < n)
    {
        summe += i;
        i--;
    }
    if(summe == n)
    {
        for (int j = i + 1; j <= start; j++)
        {
            Console.WriteLine($"{j}  ");
        }
    }
}