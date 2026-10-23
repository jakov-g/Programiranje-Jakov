using System;
using System.Globalization;

internal class Program
{
    static int ukupnoPokretanja;

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            IspisiIzbornik();
            Console.Write("Odabir: ");
            string unos = Console.ReadLine();
            int odabir;
            if (!int.TryParse(unos, out odabir))
            {
                Console.WriteLine("Pogreška: unesite broj od 0 do 20.");
                continue;
            }
            if (odabir == 0)
            {
                Console.WriteLine($"Ukupno pokretanja zadataka: {ukupnoPokretanja}");
                Console.WriteLine("Doviđenja!");
                break;
            }
            if (odabir < 1 || odabir > 20)
            {
                Console.WriteLine("Nepoznata opcija. Pokušajte ponovno.");
                continue;
            }
            ukupnoPokretanja++;
            Console.WriteLine();
            switch (odabir)
            {
                case 1: Zadatak01(); break;
                case 2: Zadatak02(); break;
                case 3: Zadatak03(); break;
                case 4: Zadatak04(); break;
                case 5: Zadatak05(); break;
                case 6: Zadatak06(); break;
                case 7: Zadatak07(); break;
                case 8: Zadatak08(); break;
                case 9: Zadatak09(); break;
                case 10: Zadatak10(); break;
                case 11: Zadatak11(); break;
                case 12: Zadatak12(); break;
                case 13: Zadatak13(); break;
                case 14: Zadatak14(); break;
                case 15: Zadatak15(); break;
                case 16: Zadatak16(); break;
                case 17: Zadatak17(); break;
                case 18: Zadatak18(); break;
                case 19: Zadatak19(); break;
                case 20: Zadatak20(); break;
            }
            Console.WriteLine("\n--- Kraj zadatka ---\n");
        }
    }

    static void IspisiIzbornik()
    {
        Console.WriteLine("========== ZBIRKA ZADATAKA ==========");
        Console.WriteLine(" 1 - Zbroj i razlika         11 - Tablica množenja");
        Console.WriteLine(" 2 - Pravokutnik             12 - Znamenke broja");
        Console.WriteLine(" 3 - Krug                    13 - Prost broj");
        Console.WriteLine(" 4 - Pretvorba temperature   14 - Faktorijel petljom");
        Console.WriteLine(" 5 - Popust u trgovini       15 - Analiza teksta");
        Console.WriteLine(" 6 - Najveći i najmanji      16 - Palindrom");
        Console.WriteLine(" 7 - Parnost i djeljivost    17 - Statistika polja");
        Console.WriteLine(" 8 - Ocjena iz postotka      18 - Pretraživanje polja");
        Console.WriteLine(" 9 - Mini kalkulator         19 - Sortiranje polja");
        Console.WriteLine("10 - Zbroj i prosjek 1...N   20 - Evidencija bodova");
        Console.WriteLine(" 0 - Izlaz");
    }

    // unos brojeva
    static int UcitajInt(string poruka, int min = int.MinValue, int max = int.MaxValue)
    {
        int broj;
        while (true)
        {
            Console.Write(poruka);
            if (int.TryParse(Console.ReadLine(), out broj) && broj >= min && broj <= max)
            {
                return broj;
            }
            Console.WriteLine("Pogresan unos. Pokusaj ponovno.");
        }
    }

    static double UcitajDouble(string poruka, double min = double.MinValue, double max = double.MaxValue)
    {
        double broj;
        while (true)
        {
            Console.Write(poruka);
            string unos = Console.ReadLine();
            if (unos != null)
            {
                unos = unos.Replace('.', ',');
                if (double.TryParse(unos, NumberStyles.Float, CultureInfo.GetCultureInfo("hr-HR"), out broj) && broj >= min && broj <= max)
                {
                    return broj;
                }
            }
            Console.WriteLine("Pogresan unos. Pokusaj ponovno.");
        }
    }

    static string UcitajIme(string poruka)
    {
        while (true)
        {
            Console.Write(poruka);
            string ime = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(ime))
            {
                return ime;
            }
            Console.WriteLine("Unesi ime.");
        }
    }

    static void Zadatak01()
    {
        int a = UcitajInt("Prvi broj: ");
        int b = UcitajInt("Drugi broj: ");
        Console.WriteLine($"Zbroj: {Zbroji(a, b)}");
        Console.WriteLine($"Razlika: {Oduzmi(a, b)}");
    }
    static int Zbroji(int a, int b)
    {
        return a + b;
    }
    static int Oduzmi(int a, int b)
    {
        return a - b;
    }

    static void Zadatak02()
    {
        double a = UcitajDouble("Stranica a: ", 0.000000001);
        double b = UcitajDouble("Stranica b: ", 0.000000001);
        Console.WriteLine($"Opseg: {OpsegPravokutnika(a, b):F2}");
        Console.WriteLine($"Površina: {PovrsinaPravokutnika(a, b):F2}");
    }
    static double OpsegPravokutnika(double a, double b)
    {
        return 2 * (a + b);
    }
    static double PovrsinaPravokutnika(double a, double b)
    {
        return a * b;
    }

    static void Zadatak03()
    {
        double r = UcitajDouble("Polumjer: ", 0.000000001);
        Console.WriteLine($"Opseg: {OpsegKruga(r):F2}");
        Console.WriteLine($"Površina: {PovrsinaKruga(r):F2}");
    }
    static double OpsegKruga(double r)
    {
        return 2 * Math.PI * r;
    }
    static double PovrsinaKruga(double r)
    {
        return Math.PI * r * r;
    }

    static void Zadatak04()
    {
        int izbor = UcitajInt("1 - °C u °F, 2 - °F u °C: ", 1, 2);
        double temperatura = UcitajDouble("Temperatura: ");
        if (izbor == 1) Console.WriteLine($"{temperatura:F2} °C = {CelsiusUFahrenheit(temperatura):F2} °F");
        else Console.WriteLine($"{temperatura:F2} °F = {FahrenheitUCelsius(temperatura):F2} °C");
    }
    static double CelsiusUFahrenheit(double c)
    {
        return c * 9 / 5 + 32;
    }
    static double FahrenheitUCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    static void Zadatak05()
    {
        double cijena = UcitajDouble("Početna cijena: ", 0);
        double popust = UcitajDouble("Popust u postotcima: ", 0, 100);
        Console.WriteLine($"Iznos popusta: {cijena - KonacnaCijena(cijena, popust):F2}");
        Console.WriteLine($"Konačna cijena: {KonacnaCijena(cijena, popust):F2}");
    }
    static double KonacnaCijena(double cijena, double popust)
    {
        return cijena * (1 - popust / 100);
    }

    static void Zadatak06()
    {
        int a = UcitajInt("Prvi broj: "), b = UcitajInt("Drugi broj: "), c = UcitajInt("Treći broj: ");
        Console.WriteLine($"Najveći: {Najveci(a, b, c)}");
        Console.WriteLine($"Najmanji: {Najmanji(a, b, c)}");
    }
    static int Najveci(int a, int b, int c)
    {
        int najveci = a;
        if (b > najveci) najveci = b;
        if (c > najveci) najveci = c;
        return najveci;
    }
    static int Najmanji(int a, int b, int c)
    {
        int najmanji = a;
        if (b < najmanji) najmanji = b;
        if (c < najmanji) najmanji = c;
        return najmanji;
    }

    static void Zadatak07()
    {
        int n = UcitajInt("Cijeli broj: ");
        if (JeParan(n)) Console.WriteLine("Broj je paran.");
        else Console.WriteLine("Broj je neparan.");
        if (JeDjeljiv(n, 3)) Console.WriteLine("Djeljiv je s 3.");
        else Console.WriteLine("Nije djeljiv s 3.");
        if (JeDjeljiv(n, 5)) Console.WriteLine("Djeljiv je s 5.");
        else Console.WriteLine("Nije djeljiv s 5.");
    }
    static bool JeParan(int n)
    {
        return n % 2 == 0;
    }
    static bool JeDjeljiv(int n, int djelitelj)
    {
        return n % djelitelj == 0;
    }

    static void Zadatak08()
    {
        int p = UcitajInt("Postotak (0-100): ", 0, 100);
        Console.WriteLine($"Ocjena: {OdrediOcjenu(p)}");
    }
    static int OdrediOcjenu(int postotak)
    {
        if (postotak < 50) return 1;
        if (postotak < 63) return 2;
        if (postotak < 76) return 3;
        if (postotak < 89) return 4;
        return 5;
    }

    static void Zadatak09()
    {
        double a = UcitajDouble("Prvi broj: ");
        double b = UcitajDouble("Drugi broj: ");
        Console.Write("Operacija (+, -, *, /): ");
        string operacija = Console.ReadLine();
        if (operacija != "+" && operacija != "-" && operacija != "*" && operacija != "/")
        {
            Console.WriteLine("Nepoznata operacija.");
            return;
        }
        if (operacija == "/" && b == 0)
        {
            Console.WriteLine("Dijeljenje nulom nije dopušteno.");
            return;
        }
        Console.WriteLine($"Rezultat: {Izracunaj(a, b, operacija)}");
    }
    static double Izracunaj(double a, double b, string operacija)
    {
        switch (operacija)
        {
            case "+": return a + b;
            case "-": return a - b;
            case "*": return a * b;
            case "/": return a / b;
            default: return 0;
        }
    }

    static void Zadatak10()
    {
        int n = UcitajInt("N (1-100000): ", 1, 100000);
        long zbroj = ZbrojDoN(n);
        Console.WriteLine($"Zbroj: {zbroj}");
        Console.WriteLine($"Prosjek: {(double)zbroj / n:F2}");
    }
    static long ZbrojDoN(int n)
    {
        long zbroj = 0;
        for (int i = 1; i <= n; i++) zbroj += i;
        return zbroj;
    }

    static void Zadatak11()
    {
        int broj = UcitajInt("Broj (1-10): ", 1, 10);
        IspisiTablicu(broj);
    }
    static void IspisiTablicu(int broj)
    {
        for (int i = 1; i <= 10; i++) Console.WriteLine($"{broj} x {i} = {broj * i}");
    }

    static void Zadatak12()
    {
        int n = UcitajInt("Broj (0-1000000000): ", 0, 1000000000);
        Console.WriteLine($"Broj znamenaka: {BrojZnamenaka(n)}");
        Console.WriteLine($"Zbroj znamenaka: {ZbrojZnamenaka(n)}");
    }
    static int BrojZnamenaka(int n)
    {
        int broj = 0;
        do { broj++; n /= 10; } while (n > 0);
        return broj;
    }
    static int ZbrojZnamenaka(int n)
    {
        int zbroj = 0;
        do { zbroj += n % 10; n /= 10; } while (n > 0);
        return zbroj;
    }

    static void Zadatak13()
    {
        int n = UcitajInt("Broj (>= 0): ", 0);
        Console.WriteLine(JeProst(n) ? "Broj je prost." : "Broj nije prost.");
    }
    static bool JeProst(int n)
    {
        if (n < 2) return false;
        for (int i = 2; (long)i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    static void Zadatak14()
    {
        int n = UcitajInt("N (0-20): ", 0, 20);
        Console.WriteLine($"{n}! = {Faktorijel(n)}");
    }
    static long Faktorijel(int n)
    {
        long rezultat = 1;
        for (int i = 2; i <= n; i++) rezultat *= i;
        return rezultat;
    }

    static void Zadatak15()
    {
        Console.Write("Unesite rečenicu: ");
        string tekst = Console.ReadLine() ?? "";
        Console.WriteLine($"Znakova: {tekst.Length}");
        Console.WriteLine($"Samoglasnika: {BrojSamoglasnika(tekst)}");
        Console.WriteLine($"Razmaka: {BrojRazmaka(tekst)}");
    }
    static int BrojSamoglasnika(string tekst)
    {
        int broj = 0;
        foreach (char znak in tekst.ToLowerInvariant())
            if (znak == 'a' || znak == 'e' || znak == 'i' || znak == 'o' || znak == 'u') broj++;
        return broj;
    }
    static int BrojRazmaka(string tekst)
    {
        int broj = 0;
        foreach (char znak in tekst) if (znak == ' ') broj++;
        return broj;
    }

    static void Zadatak16()
    {
        Console.Write("Unesite tekst: ");
        string tekst = Console.ReadLine() ?? "";
        Console.WriteLine(JePalindrom(tekst) ? "Tekst je palindrom." : "Tekst nije palindrom.");
    }
    static bool JePalindrom(string tekst)
    {
        string bezRazmaka = tekst.Replace(" ", "").ToLowerInvariant();
        int lijevo = 0;
        int desno = bezRazmaka.Length - 1;
        while (lijevo < desno)
        {
            if (bezRazmaka[lijevo] != bezRazmaka[desno]) return false;
            lijevo++;
            desno--;
        }
        return true;
    }

    static int[] UcitajPolje(int n)
    {
        int[] polje = new int[n];
        for (int i = 0; i < n; i++) polje[i] = UcitajInt($"Element [{i}]: ");
        return polje;
    }

    static void Zadatak17()
    {
        int n = UcitajInt("Broj elemenata (3-20): ", 3, 20);
        int[] a = UcitajPolje(n);
        long zbroj = ZbrojPolja(a);
        Console.WriteLine($"Zbroj: {zbroj}");
        Console.WriteLine($"Aritmetička sredina: {(double)zbroj / a.Length:F2}");
        Console.WriteLine($"Najmanji: {NajmanjiUPolju(a)}");
        Console.WriteLine($"Najveći: {NajveciUPolju(a)}");
    }
    static long ZbrojPolja(int[] a)
    {
        long zbroj = 0;
        foreach (int broj in a) zbroj += broj;
        return zbroj;
    }
    static int NajmanjiUPolju(int[] a)
    {
        int najmanji = a[0];
        foreach (int broj in a) if (broj < najmanji) najmanji = broj;
        return najmanji;
    }
    static int NajveciUPolju(int[] a)
    {
        int najveci = a[0];
        foreach (int broj in a) if (broj > najveci) najveci = broj;
        return najveci;
    }

    static void Zadatak18()
    {
        int[] a = UcitajPolje(10);
        int trazeni = UcitajInt("Traženi broj: ");
        Console.WriteLine($"Broj pojavljivanja: {BrojPojavljivanja(a, trazeni)}");
        Console.Write("Indeksi: ");
        bool pronaden = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == trazeni)
            {
                if (pronaden) Console.Write(", ");
                Console.Write(i);
                pronaden = true;
            }
        }
        if (!pronaden) Console.Write("nema pojavljivanja");
        Console.WriteLine();
    }
    static int BrojPojavljivanja(int[] a, int trazeni)
    {
        int broj = 0;
        foreach (int element in a) if (element == trazeni) broj++;
        return broj;
    }

    static void Zadatak19()
    {
        int[] brojevi = UcitajPolje(8);
        Console.WriteLine("Izvorni poredak: " + string.Join(", ", brojevi));
        SortirajUzlazno(brojevi);
        Console.WriteLine("Uzlazno: " + string.Join(", ", brojevi));
    }
    static void SortirajUzlazno(int[] brojevi)
    {
        for (int i = 0; i < brojevi.Length - 1; i++)
        {
            for (int j = 0; j < brojevi.Length - 1 - i; j++)
            {
                if (brojevi[j] > brojevi[j + 1])
                {
                    int pomocni = brojevi[j];
                    brojevi[j] = brojevi[j + 1];
                    brojevi[j + 1] = pomocni;
                }
            }
        }
    }

    static void Zadatak20()
    {
        int n = UcitajInt("Broj učenika (3-10): ", 3, 10);
        string[] imena = new string[n];
        int[] postotci = new int[n];
        for (int i = 0; i < n; i++)
        {
            imena[i] = UcitajIme($"Ime učenika {i + 1}: ");
            postotci[i] = UcitajInt("Postotak (0-100): ", 0, 100);
        }
        int najbolji = 0, prolaznih = 0;
        long ukupno = 0;
        Console.WriteLine("\nRezultati:");
        for (int i = 0; i < n; i++)
        {
            IspisiUcenika(imena[i], postotci[i]);
            IspisiUcenika(imena[i], postotci[i], OdrediOcjenu(postotci[i]));
            ukupno += postotci[i];
            if (postotci[i] >= 50) prolaznih++;
            if (postotci[i] > postotci[najbolji]) najbolji = i;
        }
        Console.WriteLine($"Prosječan postotak: {(double)ukupno / n:F2}%");
        Console.WriteLine($"Najbolji učenik: {imena[najbolji]} ({postotci[najbolji]}%)");
        Console.WriteLine($"Broj prolaznih: {prolaznih}");
    }
    static void IspisiUcenika(string ime, int postotak)
    {
        Console.WriteLine($"Učenik: {ime}, postotak: {postotak}%");
    }
    static void IspisiUcenika(string ime, int postotak, int ocjena)
    {
        Console.WriteLine($"{ime} ima ocjenu {ocjena}.");
    }
}
