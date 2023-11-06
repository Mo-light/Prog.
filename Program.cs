namespace Projekt._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Teilaufgabe a (Überprüfe, ob die Eingabe im richtigen Bereich liegt).
            // Schleife wird neu gestarted wenn "antwort" kleiner 10 oder größer 10000 ist.
            int antwort;
            do
            {
                Console.WriteLine("Bitte geben Sie eine Zahl größer gleich 10 und kleiner als 10000 ein:");
                antwort = Convert.ToInt32(Console.ReadLine());
                if (!((antwort == 10 || antwort > 10) && antwort < 10000))
                {
                    Console.WriteLine("Ungültige Eingabe, bitte wiederholen.");
                }
            }
            while (!((antwort == 10 || antwort > 10) && antwort < 10000));
            Console.WriteLine("\n--------------------\n");






            //Teilaufgabe b (Ausgabe der Zahlen abhängig von der Größe der eingegebenen Zahl)
            //tmp ist ein Äquivalent zu der int-Variable "antwort" und wird verwendet, weil der Wert der int-Variable "antwort" nicht verändert werden darf, da sie in anderen Teilaufgaben benötigt wird.
            int tmp = antwort;
            if (antwort <= 50)
            {
                Console.WriteLine($"Da Sie eine Zahl gewählt haben, die kleiner/gleich 50 ist, gibt es keine Zahl zwischen 0 und {antwort}, die durch 50 teilbar ist.");
            }
            else
            {
                tmp = antwort - 1; // Die Zahl selbst gehört nicht zu unserer Definitionsmenge für dieses Teil der Frage.
                if (antwort < 1000)
                {
                    Console.WriteLine($"Zahlen zwischen 0 und {antwort}, die durch 50 teilbar sind:");

                    // alle natürliche Zahlen die kleiner als "antwort" sind weden nach Teilbarkeit auf 50 untersucht und nur wenn sie Teilbar sind werden sie notiert.
                    while (!(tmp == 0))
                    {
                        if (tmp % 50 == 0)
                        {
                            Console.WriteLine(tmp);
                        }
                        tmp--;
                    }
                }
                
                if (antwort >= 1000 && antwort < 10000)
                {
                    Console.WriteLine($"Zahlen kleiner als {antwort}, die durch 500 teilbar sind:");
                    // alle natürliche Zahlen die kleiner als "antwort" sind weden nach Teilbarkeit auf 500 untersucht und nur wenn sie Teilbar sind werden sie notiert.
                    while (tmp != 0)
                    {
                        if (tmp % 500 == 0)
                        {
                            Console.WriteLine(tmp);
                        }
                        tmp--;
                    }
                }
                
            }
            Console.WriteLine("\n--------------------\n");






            //Teilaufgabe c (Berechnung der Summe den echten Teiler)
            // Das kleinste mögliche Divisor in intervall  1 < Divisor < antwort, ist 2.
            int divisor = 2;
            int summe = 0;
            //In der Schleife wird überprüft, ob der Wert der int-Variable "antwort" durch den Divisor teilbar ist.
            //Wenn ja, wird der Divisor notiert, und sein Wert wird zur Summe addiert. Dieser Vorgang wird wiederholt, bis der Divisor den Wert von dem int-Variable "antwort" erreicht.
            Console.WriteLine($"Teiler von {antwort}:");
            while (divisor != antwort)
            {
                if (antwort % divisor == 0)
                {
                    Console.WriteLine(divisor);
                    summe += divisor;
                }
                divisor++;
            }
            if (summe == 0)
            {
                Console.WriteLine($"{antwort} hat keinen echten Teiler ---> {antwort} ist eine Primzahl");
            }
            else
            {
                Console.WriteLine($"Die Summe aller echten Teiler von {antwort} ist: {summe}");
            }
            Console.WriteLine("\n--------------------\n");






            //Teilaufgabe d (Berechnung der Anzahl der geraden und ungeraden Ziffern)
            //tmp Wert vom tmp = antwort züruckgeben;
            tmp = antwort;
            int geradezahl = 0;
            int ungeradezahl = 0;
            //Die Schleife wird verwendet, um die Ziffern zu extrahieren und zu überprüfen, ob sie gerade oder ungerade sind.
            //Der Wert von "tmp" wird durch sukzessive Teilung durch 10 verkleinert, um jede Ziffer zu isolieren.
            while (tmp != 0)
            {
                int ziffer = tmp % 10;
                if (ziffer % 2 == 0)
                {
                    geradezahl++;
                }
                else
                {
                    ungeradezahl++;
                }
                tmp /= 10;
            }
            Console.WriteLine($"Anzahl der geraden Ziffern: {geradezahl}");
            Console.WriteLine($"Anzahl der ungeraden Ziffern: {ungeradezahl}");
            Console.WriteLine("\n--------------------\n");






            // Teilaufgabe e (Berechnung des Produkts der ersten und letzten Ziffer)
            // antwort % 10 gibt den Rest der Division von antwort durch 10 zurück was auch die letzte Ziffer der Zahl "antwot" entspricht.
            //Der Ausdruck "erstenZiffer /= 10" entfernt die letzte Ziffer der Zahl, und dies wird wiederholt, bis nur noch die erste Ziffer übrig bleibt.
            int letztenZiffer = antwort % 10;
            int erstenZiffer = antwort;
            while (erstenZiffer >=10)
            {
                erstenZiffer /= 10;
            }
            Console.WriteLine($"Das Produkt der ersten und letzten Ziffer von {antwort} ist {erstenZiffer} * {letztenZiffer}  = {letztenZiffer * erstenZiffer}");
            Console.WriteLine("\n--------------------\n");






            // Teilaufgabe f (Überprüfung, ob die Zahl eine Dreieckszahl ist)
            // Die Schleife mit `while` und `i` berechnet die Summe aller natürlichen Zahlen von 1 bis die summe von die natürliche Zahlen gleich oder größer ist als der Wert der int-Variable "antwort". 
            int sum = 0;
            int i = 1;
            while (sum < antwort)
            {
                sum += i;
                i++;
            }
            if (sum == antwort)
            {
                Console.WriteLine($"{antwort} ist eine Dreieckszahl.");
            }
            else
            {
                Console.WriteLine($"{antwort} ist keine Dreieckszahl.");
            }
        Console.WriteLine("\n--------------------\n--------------------\n");
        }
    }
            
}