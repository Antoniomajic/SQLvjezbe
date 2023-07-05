

namespace E01KlasaObjekt
{
    // Ovo morate znati nakon svatova u 4 ujutro!
    // Klasa je opisnik objekta- dakle klasa opisuje objekt
    internal class Osoba // internal znači da je vidljivo samo u tom projektu
    {
        // ovako se ne smiju deklarirati svojstva u klasi
        // zato što nije zadovoljen OOP princip učahurivanja
        //public string ime;
        //internal string prezime;
        //int godine;

        // zadnja vrsta metoda: konstruktor 
        // poziva se u trenutku instancirajna novog objekta (ključna riječ new)
        // ona nije obavezna. Ako nije definirana poziva se konstruktor iz nadklase (nasljeđivanje)

        // naziv konstruktora mora biti identičan nazivu klase
        public Osoba()
        {
            Console.WriteLine("Konstruktor klase Osoba");
        }

        public Osoba(string ime)
        {
            Console.WriteLine(ime);
        }



    }
}
// private znači da ga vidi samo ta klasa