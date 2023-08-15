using E01KlasaObjekt;

string ime = "Pero";
string prezime = "Perić";
int godine = 24;

ime = "marija";

string ime1 = "marija";

// ako želimo puno imena onda nema smisla ići sa varijablama

// 1. principi OOP-a su KLASA I OBJEKT


// Ovo moram znazi nakon svatova u 4 ujutro
// OBJEKT JE INSTANCA/POJAVNOST KLASE 
// pojavnosti objekata mogu biti različite ali je struktura ista


Osoba o = new Osoba();
// Osoba je naziv klase(tip podatka)
// o je instanca klase, o je objekt, o je varijabla
// new je ključna riječ koja poziva posebnu metodu: konstruktor
// konstruktori se pozivaju u trenutku instanciranja novog objekta na osnovu neke klase koju smo definirali


o = new Osoba("Pero");
// gore sam zvao konstruktor koji ne prima ni jedan parametar, a ovaj drugi prima jedan parametar(tipa string)


// eksplicitni način deklariranja varijabli
Osoba natjecatelj = new Osoba();
// kao da je pisano string natjecatelj npr. "Marko"


// implicitni način deklariranja varijabli
var prijavitelj = new Osoba("Marija");
// implicitni način s lijeve strane nema tip kojeg je nego desna strana definira koji je tip
// dakle desna strana određuje tip podatka varijable

var i = 1; // uvijek smo išli int i ali može i ovako

var dokument1 = new Dokument("Naziv dokumenta");
var dokument2 = new Dokument();
var dokument3 = new Dokument("Drugi naziv");

// Z01
// profesor
Dokument[] dokumenti = new Dokument[3];
// kada se kaže tri instance klase to ne moraju biti varijable već mogu biti i elementi niza
dokumenti[0] = new Dokument();
dokumenti[1] = new Dokument();
dokumenti[2] = new Dokument("Račun");

// Z02
// uobičajeno je varijablu nazvati kao i klasu
Smjer smjer = new Smjer("Mora biti string",3);


// z03
Grupa grupa = new Grupa();  // deklariram izvan petlje; isto ponašanje sa klasama kao i sa tipovima podataka jer nećemo deklarirati unutar petlje


for(int j=0; j<128; j++)
{
    grupa = new Grupa();
}
 
