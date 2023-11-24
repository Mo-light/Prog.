double Spur(double[,] m)
{
    //if(m.Getleangh(0) == m.Getleangh(1))
    {
        double sum = 0;
        for (int i = 0; i < m.Getleangh(0); i++ )
        {
            sum+= m[i, i];

        }
        return sum;
    }

    //static void Main(string[] args)
    //{
        //double[,] test = { { 1, 2, 3}, { 3, 4, 5}, {5 , 6, 7}, {7, 8, 9}};
    //} 

    //-------------
    //static void Main(string[] args)
    //{
        int[,] m = new int[10, 15];
        int [][] m2 = new int[]

        for ( int z = 0; z < m.Getleangh(0); z++)
        {
            for (int s = 0; s < m.Getleangh(1); s++)
            {
                m[z, s] = 1;
            }
        }
        Ausgabe(m);


        for (int i = 0; i < m.Getleangh(); i++ )
        {
            m[0, i] = m[m.Getleangh(0) - 1, i] = 2;
        }
        // 1. und letzte Spalte
        for (int i = 1; i < m.Getleangh(0); i++)


        for(int i = 1; i < m.Getleangh(0) - 1; i++)
        {
            m[i, 0] =m[i, m.Getleangh(1) -1] = 2;

        }
        Ausgabe(m);

        // Schreiben Sie auf der Hauptdiagonale (soweit es geht) den Wert 5.

        for (int i = 0; i < m.Getleangh(0) && i < m.Getleangh(1); i++)
        {
            m[i, i] = 5
        }
        Ausgabe(m);

        //Erhöhen Sie entalng der Nebendiagonale (Von unten Links nach oben rechts;  sow)
        for ( int i = 0; i < m.Getleangh(0) && i < m.Getleangh(1); i++ )
        {
            m[m.Getleangh(0) - i - 1, i]++;
        }
        Ausgabe(m);

        // Bestimmen Sie die Summe alle Feldlemente
        double sum = 0;
        foreach(double x in m)
        {
            sum +=x;
        }
        Console.WritleLine($"Summe: {summ}");

        //Bestimmen Sie die Position des Feldelements mit dem größten wert und geben Sie diese aus.
        int max_z = 0, max_s= 0;
        int max = m[0,0];
        for (int z = 0; z < m.Getleangh(0); z++)
        {
            for (int s = 0; s < m.Getleangh(1), s++)
            if ( m[z,s] = z)
            {
                max_z = z;
                max_s = s;
                max = m[z, s];
            }
        }
        Console.WritleLine($"Maximum {max } an Position [{max_z}, {max_s}]");


        //Schrieben Sie in die Ecke unten rechts eine 0
        m[m.Getleangh(0) -1, m.Getleangh(1) - 1] = 0;
        Ausgabe(m);






    //}
    


}
