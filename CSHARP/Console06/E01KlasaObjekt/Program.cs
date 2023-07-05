
using E01KlasaObjekt;

string ime = "Pero";
string prezime = "Perić";
int godine = 24;

ime = "marija";

string ime1 = "marija";

// Ovo morate znati nakon svatova u 4 ujutro!
// objekt je instanca/pojavnost klase
// Osova je naziv klase (tip podatka)
// o je instanca klase; o je objekt, o je varijabla
// new je ključna riječ koja poziva posebnu metodu: konstruktor
Osoba o = new Osoba();

o = new Osoba("Pero");

// eksplicitni način deklariranja varijabli
Osoba natjecatelj = new Osoba();


// implicitni način deklariranja varijabli

var prijavitelj = new Osoba("Marija");  // desna strana definira koji je tip podatka varijable
var i = 1;

// drugi dio Z01
Dokument[] dokumenti = new Dokument[3];
dokumenti[0] = new Dokument();
dokumenti[1] = new Dokument();
dokumenti[2] = new Dokument("Račun");

// Z02
Smjer smjer = new Smjer("mora biti string",3);

// Z03

Grupa grupa;

for(int j = 0; j < 128; j++)
{
    grupa = new Grupa();
}
