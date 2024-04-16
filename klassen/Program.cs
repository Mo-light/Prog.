using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
class Konto
{
    private int nr;
    private double saldo;
    private double dispo;


    public Konto(int _nr)
    {
        nr = _nr;
        dispo = 1000;
        saldo = 0;
    }

    public void Einzahlen(double betrag)
    {
        if ( betrag >= 0)
        {
            saldo +=betrag;
        }
        
    }

    public void Auszahlen(double betrag)
    {
        if (betrag >= 0)
        {
            if ( saldo + dispo >= betrag)
            {
                saldo -= betrag;
            }
        }
    }

    public double Saldo()
    {
        return saldo;
    }

    public void SetDipo(double d)
    {
        if (d >= 0)
        {
            dispo = d;
        }
    
    }

    //public void Uberweisung(double betrag, Konto k)
    //{
    //    Auszahlen(betrag);
    //    k.Einzahlen(betrag);
    //}
    // Test Test jol
  
}
