//GRANANJE


using System.ComponentModel.Design;
using System.Net;
using System.Numerics;

int i = 1;

bool uvjet = i > 0;

if (uvjet)
{
    Console.WriteLine("01: Veće od 0");
}

// koristiti ćemo ovu sintaksu

if (i > 0)
{
    Console.WriteLine("02: Opet veće od 0");
}

// jedna od većih grešaka - NE KORISTITI
if (uvjet == true)
{

}

// ako se if odnosi na jednu liniju ne trebaju {}
if (!uvjet)
    Console.WriteLine("03: Nije veće od 0");
Console.WriteLine("04: Ovo isto ne bi trealo biti veće od 0");

// no mi ćemo uvijek koristiti {}

string grad = "Osijek";

if (grad == "Osijek")
{
    Console.WriteLine("05. SUPER");
}
else
{
    Console.WriteLine("06: OK");
}


// ako je grad jednako Osijek onda ispiši super, ako nije onda ispiši ok

int b = 0;
if (grad != "Zagreb")
{
    b = b + 1; // broj b se uvećava za 1
}
else if (grad == "Split")
{
    b += 1; // broj b se uvećeva za 1
}
else if (grad == "Osijek")
{
    b += 2; // broj b se uvećava za 2
}
else
{
    b++; //broj b se uvećava za 1
}

Console.WriteLine("07: " + b);

// if možemo ugnjezditi
i = 0; b = 2;

if (i > 0)
{
    if (b == 2)
    {
        Console.WriteLine("08: Oba uvjeta su zadovoljena");
    }
}

// korištenje logičkih operatora
if (i > 0 && b == 2)
{
    Console.WriteLine("09: Oba uvjeta su zadovoljena");
}

if (i == 4 || b < 0)
{

}

int g = 10;

if (g % 2 == 0)
{
    Console.WriteLine("10: Broj je paran");
}
else
{
    Console.WriteLine("11: Broj je neparan");
}

// operator ? - inline if
//ovaj jedan rej je istovjeran linijama 91-98
Console.WriteLine("12: Broj je " + (g % 2 == 0 ? "" : "ne") + "paran");

/* 1. Zadatak 
 * Korisnik unosi cijeli broj
 * Za broj manji od 10 ispisuje se Osijek
 * Inače se ispisuje Donji Miholjac
 */

Console.WriteLine("Unesi cijeli broj: ");
int br1 = int.Parse(Console.ReadLine());

if (br1 < 10)
{
    Console.WriteLine("Osijek");
}
else
{
    Console.WriteLine("Donji Miholjac");
}

/* 2. Zadatak
 * Korisnik unosi cijeli broj
 * Program ispisuje da li je 
 * paran ili nije
 */

Console.WriteLine("Unesi cijeli broj: ");
int br2 = int.Parse(Console.ReadLine());
if (br2 % 2 == 0)
{
    Console.WriteLine("Broj je paran");
}
else
{
    Console.WriteLine("Broj je neparan");
}

/* 3. zadatak 
 * Za dva unesena cijela broja
 * program ispisuje Osijek
 * ako je zbroj veći od 10
 * inače ispisuje Edunova
 */

Console.WriteLine("Unesi prvi broj: ");
int br3 = int.Parse(Console.ReadLine());
Console.WriteLine("Unesi drugi broj");
int br4 = int.Parse(Console.ReadLine());

if (br3 + br4 > 10)
{
    Console.WriteLine("Osijek");
}
else
{
    Console.WriteLine("Edunova");
}
