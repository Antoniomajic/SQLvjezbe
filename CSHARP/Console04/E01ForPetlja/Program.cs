// 10 puta ispiši Osijek

// najgore rješenje

//Console.WriteLine("Osijek");
//Console.WriteLine("Osijek");
//Console.WriteLine("Osijek");
//Console.WriteLine("Osijek");
//Console.WriteLine("Osijek");
//Console.WriteLine("Osijek");
//Console.WriteLine("Osijek");
//Console.WriteLine("Osijek");
//Console.WriteLine("Osijek");
//Console.WriteLine("Osijek");

// for (od kuda; do kuda; korak)

Console.WriteLine("1. ***************");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Osijek");
}

Console.WriteLine("2. ***************");
int j = 0;
for (j = 10; j > 0; j--)
{
    Console.WriteLine("Osijek");
}

// Domaća zadaća: vježbati s break point i debug

Console.WriteLine("3. ***************");
for (int i = 0; i < 10; i = i + 2)
{
    Console.WriteLine("CSHARP");
}

// varijabla u petlji mijenja vrijednost!!!!
Console.WriteLine("4. ***************");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("5. ***************");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + 1); // i + 1 ne mijenja vrijednost varijable
}

Console.WriteLine("6. ***************");
// ne koristiti
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("7. ***************");
// zbroj prvih 100 brojeva
int zbroj = 0;
for (int i = 1; i <= 100; i++)
{
    //Console.WriteLine(i); // ovo će ispisati sve brojeve od 1 do 100
    //Console.WriteLine(zbroj); // ovo će ispisati sto nula
    zbroj += i; // zbroj=zbroj+i
    Console.WriteLine(zbroj); // ovo je isparavan ispan nakon koda iznad
}

Console.WriteLine("8. ***************");
// ipisati sve parne brojeve od 1 do 57
for (int i = 1; i <= 57; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}


Console.WriteLine("9. ***************");
// ispiši zboj svih parnih brojeva od 2 do 18
zbroj = 0;
for (int i = 2; i <= 18; i++)
{
    if (i % 2 == 0)
    {
        zbroj = zbroj + i;
    }
}
Console.WriteLine(zbroj);

Console.WriteLine("10. ***************");
// jedno ispod drugog ipisati svaki element niza
int[] niz = { 13, 45, 52, 11, 3, 2, 1, 8, 6 };

for (int i = 0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}

/* Program učitava koliko će se brojeva unijeti
 * Program učitava brojeve za provjeru
 * Program ispisuje najveći uneseni broj
 */

Console.WriteLine("11. ***************");
Console.WriteLine("Unesi koliko brojeva provjeravaš: ");
int brojeva = int.Parse(Console.ReadLine());
int broj; // unutar petlje nikada ne deklarirati varijablu, uvijek izvan petlje
int najveci = int.MinValue;
for (int i = 0; i < brojeva; i++)
{
    Console.WriteLine("Unesi {0}. broj: ", i + 1);
    broj = int.Parse(Console.ReadLine());
    if (broj > najveci)
    {
        najveci = broj;
    }
}
Console.WriteLine("Najveći broj je {0}", najveci);

// beskonačna petlja

// ovo nije beskonačna petlja
// for (int i=1; i>0; i++)
// {

// }

Console.WriteLine("12. ***************");
// OVO JE BESKONAČNA PETLJA
// nasilno prekidanje petlje: break;
for (; ; )
{
    Console.WriteLine(new Random().NextDouble()); // loša sintaksa
    break;
}

Console.WriteLine("12. ***************");
for (int i = 0; i < 10; i++)
{
    if (i == 3)
    {
        break;
    }
    Console.WriteLine(i);
}

// petlja se može nastaviti/preskočiti
Console.WriteLine("13. ***************");
for (int i = 0; i < 10; i++)
{
    if (i == 2 || i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}

Console.WriteLine("14. ***************");
// ugnježđivanje petlji
string s;
for (int i = 1; i <= 10; i++)
{
    for (int k = 1; k <= 10; k++)
    {
        s = "    " + i * k;
        Console.WriteLine(s[^4..]);
    }
    Console.WriteLine();
}

// nasilno prekidanje unutarnjih petlji
Console.WriteLine("15. ***************");
for (int i = 0; i < 10; i++)
{
    for (int k = 0; k < 10; k++)
    {
        //break; // ovo prekida samo unutarnju petlju
        // želim prekinuti i vanjsku petlju
        goto labela;
    }
}

labela:;







