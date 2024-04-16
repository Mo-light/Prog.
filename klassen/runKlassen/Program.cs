Konto k1 = new Konto(123);
k1.Einzahlen(6);
Console.WriteLine(k1.Saldo());
k1.Auszahlen(0);
Console.WriteLine(k1.Saldo());