// Erstellen sie eine Funktion, sie prüft ob ein übergebenes int-Feld aufsteigend sortiert ist.

// a: x x x x x x x x x x x
//              

static bool IstSortiert(int[] a)
{
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i-1] > a[i])
        {
            return false;
        }
    }
    return true;
}

//nach links schiften und 0 hinzufügen
static void Shift(int[] a)
{
    a = new int[3];
    for (int i = 0; i < a.Length-1; i++)
    {
        a[i] = a[i + 1];
    }
    a[a.Length - 1] = 0;
}


//Erstelle eine Funktion, die das größte Element ihres übergebenen int-Feldes liefert
static int Max(int[] a)
{
    int maximum = a[0];
    for(int i = 1; i < a.Length; i++)
    {
        if(a[i] > maximum)
        {
            maximum = a[i];
        }
    }
    return maximum;
}


//Erstelle eine Funktion, die das kleinste Element ihres übergebenen int-Feldes liefert
static int Min(int [] a)
{
    int minimum = a[0];
    for(int i = 1; i < a.Length; i++)
    {
        minimum = a[i];
    }
    return minimum;
}




//---------------
int[] a = {1, 2, 3, 4, 5};
Console.WriteLine(IstSortiert(a));

Shift(a);

Console.WriteLine(Max(a));
Console.WriteLine(Min(a));