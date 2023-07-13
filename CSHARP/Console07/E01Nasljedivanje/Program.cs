

using E01Nasljedivanje;

var o = new Osoba
{
    Sifra = 1,
    Ime = "Pero",
    Prezime = "Perić"
};

Console.WriteLine(o.Ime + " " + o.Prezime);
Console.WriteLine(o); // izvedi se metoda ToString

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
    BrojUgovora="2023/5614"
};

Console.WriteLine(p);

var pr = new Predavac
{
    Sifra = 1,
    Ime = "Rita",
    Prezime = "Man",
    Iban = "HR45456454211221"
};


Console.WriteLine(pr);


var pas = new Pas
{
    ZivotniVijek = "3 godine",
    TrajanjeTrudnoce = "4 mjeseca",
    Pasmina = "Terijer"
};

Console.WriteLine(pas);

var r = new Som
{
    ZivotniVijek = "12 godina",
    DuzinaPeraje = "14 cm",
    DuzinaBrkova = "6 cm"
};

Console.WriteLine(r);