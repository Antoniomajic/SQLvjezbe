using KlasaObjekt;

string ime = "Pero";
string prezime = "Perić";
int godine = 24;

ime = "marija";

string ime1 = "marija";

// Objekt je instanca/pojavnost klase

// Osoba je naziv klase (tip podatka) 
// o je instanca klase, o je objekt, o je varijabla
// new je ključna riječ koja poziva posebnu metodu: konstruktor
Osoba o = new Osoba();

o = new Osoba("Pero");

// eksplicitni način deklariranja varijabla (kad uvijek točno kažeš)
// na primjer:
Osoba natjecanje = new Osoba();


// implicitni način delariranja varijabli

var prijavitelj = new Osoba("Marija");   // desna strana određuje tip podatka varijable

var i = 1;

Dokument dokument = new Dokument();

dokument = new Dokument("Dokument 01511");

dokument = new Dokument("D 45778/ASDFAS");

dokument = new Dokument(457);

Dokument[] dokumenti = new Dokument[3];
dokumenti[0] = new Dokument();
dokumenti[1]=new Dokument();
dokumenti[2]=new Dokument("Račun");


Smjer smjer = new Smjer("Web programiranje",6);


Grupa grupa;
for(int j= 0; j < 128; j++)
{
    grupa = new Grupa();
}

