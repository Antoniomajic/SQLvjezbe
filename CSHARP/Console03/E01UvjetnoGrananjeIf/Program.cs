using System.ComponentModel.Design;

int i = 00;

bool uvjet = i > 0;

if (uvjet)
{
    Console.WriteLine("01: Veće od 0");
}

//koristiti ćemo ovu sintaksu
if (i > 0) ;
{
    Console.WriteLine("02: Opet veće od 0");

}

//jedna od većih grešaka - NE KORISTITI
if (uvjet == true) ;
{

}

// ako se if odnosi na jednu liniju ne trebaju {}
if (!uvjet)
    Console.WriteLine("03: Nije veće od 0");
    Console.WriteLine("04: Ovo isto ne bi trebalo biti veće od 0");

//uvijek ćemo korisiti {}


// opcionalna sintaksa

string grad = "Osijek";

if (grad=="Osijek")
{
    Console.WriteLine("05: SUPER");
}
else
{
    Console.WriteLine("06: OK");
}


int b = 0;
if (grad != "Zagreb") 
{
    b=b+1; //broj b se uvećava za 1
} else if (grad =="Split")
{
    b += 1; //broj b se uvećava za 1
} else if (grad =="Osijek")
{
    b += 2; //broj se uvećava za 2
}
else
{
    b++; //broj b se uvećava za 1
}

Console.WriteLine("07: " + b);

// if možemo ugnjezditi
i = 0; b = 2;

if(i> 0)
{
    if (b == 2)
    {
        Console.WriteLine("(08: Oba uvjeta su zadovoljena");
    }
}


// korištenje logičkih operatora

if (i>0 & b==2)
{
    Console.WriteLine("09: Oba uvjeta su zadovoljena");
}

if (i > 0 && b == 2)
{
    Console.WriteLine("10: Oba uvjeta su zadovoljena");
}

if(i==4 || b<0)
{

}

//and (&) ako prvi uvjet nije zadovoljen drugi se ne provjera
//ili (|) ako prvi uvjet je zadovoljen drugi se ne provjerava

int g = 10;
if (g % 2 == 0)
{
    Console.WriteLine("11: Broj je paran");
}
else
{
    Console.WriteLine("12: Broj je neparan");
}


// ? upitni operator - inline if
// ovaj jedan red je istovjetan linijama 98-105
Console.WriteLine("13: Broj je " + (g%2==0 ? "" : "ne") + "paran"); // nakon ? je true dio, a nakon : je false dio


//1. zadatak = Korisnik unosi cijeli broj. Za broj manji od 10 ispisuje se Osijek, a inače se ispisuje Donji Miholjac


Console.Write("Unesi cijeli broj ");
int broj1=int.Parse(Console.ReadLine());
Console.WriteLine(broj1 < 10 ? "Osijek" : "Donji Miholjac");

// 2. zadatak = korisnik unosi cijeli broj. Program ispisuje da li je paran ili nije

Console.Write("Unesi cijeli broj ");
int broj2= int.Parse(Console.ReadLine());
Console.WriteLine("Broj je " + (broj2%2==0 ? "" : "ne") + "paran");

// 3. zadatak = Za dva unesena cijela broja program ispisuje Osijek, ako je zbroj veći od 10, inače ispisuje Edunova

Console.Write("Unesi prvi cijeli broj: ");
int br1=int.Parse(Console.ReadLine());
Console.Write("Unesi drugi cijeli broj: ");
int br2=int.Parse(Console.ReadLine());  

if (br1+br2>10) 
{
    Console.WriteLine("Osijek");
}else if (br1+br2<10)
{
    Console.WriteLine("Edunova");
}



