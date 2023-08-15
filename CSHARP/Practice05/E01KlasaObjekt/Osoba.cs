namespace E01KlasaObjekt
{
    // KLASA JE OPISNIK OBJEKTA (klasa opisuje objekt)
    // 
    internal class Osoba // internal znači da je ova klasa vidljiva samo u ovom projektu
    {
        // ovako se ne smiju deklarirati svojstva u klasi
        // zato što niije zadovoljen OOP princip učahurivanja

        //public string ime; // ovo je svojstvo /kasnije sam stavio public
        //internal string prezime; // tu nije posebno definiran način pristupa da ide po defaultu private; kasnije sam stavio internal
        //int godine; // private znači da ga vidi samo klasa u kojoj se nalazi, a ostale ne

        // ova metoda nije tipa void, nego je top tipa koji je naveden (ime klase)
        // zadnja vrsta metoda: konstruktor
        // poziva se u trenutku instanciranja novog objekta (ključna riječ new)
        // ona nije obavezna. Ako nije definirana - poziva se konstruktor iz nadklase (nasljeđivanje)
        public Osoba()
        {
            Console.WriteLine("Konstruktor klase Osoba");
        }

        public Osoba(string ime)
        {
            Console.WriteLine(ime);
        }
        // sad imam dva konstruktora(overloading)






    }
}
