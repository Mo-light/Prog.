static void fillArray(int[] arr)
{
    Random R = new Random();
    for (int i = 0; i < arr.Length; i++ )
    {
        arr[i] = R.Next(10); //Zufallszahl

    }
}

static void Ausgabe(int[] zahlen)
{
    foreach (int z in zahlen)
    {
        Console.Write($"{z}");
        
    }
    Console.WriteLine("");
}

static int Finder(int[] a, int z)
{
    int ug = 0, og = a.Length - 1;
    int count = 0;
    while ( og > ug)
    {
        int mid = ug + (og -ug) / 2;
        if (a[mid] == z)
        {
            Console.WriteLine(count);
            return mid;
        }
        if (a[mid] > z)
        {
            og = mid -1;
            count++;
        }
        else
        {
            ug = mid + 1;
            count++;
        }
    }
    return -1;    
}
Console.WriteLine("q");
int[] q = new int[20000];
fillArray(q);
SelectionSort(q);
Finder(q, 999999);
//Ausgabe(q);




static void SelectionSort(int[] zahlen)
{
    for (int k = 0; k < zahlen.Length; k++)
    {
        int minIndex = k;
        for (int i = k; i < zahlen.Length; i++)
        {
            if (zahlen[i] < zahlen[minIndex])
            {
                minIndex = i;
            }
        }
        //tauschen
        int tmp = zahlen[k];
        zahlen[k] = zahlen[minIndex];
        zahlen[minIndex] = tmp;


    }
}

Console.WriteLine("a- Selection");
int[] a = new int [20];
fillArray(a);
Ausgabe(a);
SelectionSort(a);
Ausgabe(a);

static void BubbleSort(int[] zahlen)
{
    for (int k = 0; k < zahlen.Length; k++ )
    for ( int i = 0; i < zahlen.Length - k - 1; i++)
    if (zahlen[i] > zahlen[i + 1])
    {
        //tausch
        int tmp = zahlen[i];
        zahlen[i] = zahlen[i + 1];
        zahlen[i + 1] = tmp;
    }
}

Console.WriteLine("b-BubbleSort");
int[] b = new int [10];
fillArray(b);
Ausgabe(b);
BubbleSort(b);
Ausgabe(b);




