namespace KlasaObjekt
{
    // KLASA JE OPISNIK OBJEKTA
    internal class Osoba
    {
        // ovako se ne smiju deklarirati svojstva u klasu
        // zato što nije zadovoljen OOP princip učahurivanja
        /*
        public string ime;
        internal string prezime;
        int godine;
        */


        // zadnja vrsta metode : konstruktor
        // poziva se u trenutku instanciranja novog objekta (ključna riječ new)
        // ona nije obavezna. Ako nije definirana poziva se konstruktor iz nadklase (nasljeđjivanje)
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
