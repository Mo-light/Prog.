using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

Console.WriteLine(Contains("Grünes Gras", "Gras"));


static bool Contains(string ersteEingabe, string zweiteEingabe)
{
    for (int i = 0; i < ersteEingabe.Length - zweiteEingabe.Length +1; i++)
    {
        if (ersteEingabe[i] == zweiteEingabe[0])
        {
            int j = 0;
            while (ersteEingabe[i + j] == zweiteEingabe[j])
            {
                j++;
            }
            if (j == zweiteEingabe.Length)
            {
                return true;
            }
        
        }
    }
    return false;
}