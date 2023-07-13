using E02ApstraktnaKlasaIMetoda;

//var o = new Osoba();  abstraktnu klasu ne možemo instancirati 

var p = new Polaznik // instanca klase
{
    Ime = "Pero",
    Spol = "Muško"
};

var pr = new Predavac
{
    Ime = "Mario",
    Godine = 24
};

void ispis(Osoba o)
{
    o.Pozdravi(); // metoda Pozdravi nalazi se na klasi osoba
}

ispis(p);
ispis(pr);
