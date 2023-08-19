
using Nasljedivanje;

var o = new Osoba
{
    Sifra = 1,
    Ime = "Pero",
    Prezime = "Perić"
};


Console.WriteLine(o);

var drugaOsoba = new Osoba
{
    Sifra = 1,
    Ime = "Marina",
    Prezime = "Marić"
};

Console.WriteLine(o.Equals(drugaOsoba));

var p = new Polaznik
{
    Sifra = 1,
    Ime = "Marko",
    Prezime = "Kat",
    BrojUgovora = "2023/56"
};

Console.WriteLine(p);

var pr = new Predavac
{
    Sifra = 1,
    Ime = "Rita",
    Prezime = "Man",
    Iban = "HR4545478856121321315"
};

Console.WriteLine(pr);


var pas = new Pas
{
   Pasmina = "Bokser",
   duzinaKraljeznice = "114 cm",
   trajanjeTrudnoce = "4 mjeseca"
   
};

Console.WriteLine(pas);

var som = new Som
{
    duzinaBrkova = 11,
    duzinaPeraja = 15,
    duzinaKraljeznice = "50"

};

Console.WriteLine(som);