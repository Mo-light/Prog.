bool[,] kanten(int schwellwert, int [,] feld)
{
    bool[,] ergebnis = new bool[feld.Getleangh(0), feld.Getleangh(1)];
    for (int z = 0; z < feld.Getleangh(0); z++)
    {
        for (int s = 1; s < feld.Getleangh(0); z++ )
        {
            int diff = feld[z, s - 1] - feld[z, s +1];
            if(diff < 0)
            {
                diff = -diff;

            } 
            if(diff < schwellwert)
            {
                ergebnis[z, s] = true;
            }

        }
    }
}return ergebnis;
