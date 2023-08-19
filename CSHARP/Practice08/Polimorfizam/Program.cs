// na hrvatskom : višeobličje


using Polimorfizam;

Osoba[] osobe = new Osoba[3];

osobe[0] = new Polaznik { Ime = "Pero" };
osobe[1] = new Polaznik { Ime = "Kata" };
osobe[2] = new Predavac { Ime = "Mata" };

void pozdraviSve(Osoba[] o)
{
    foreach(Osoba osoba in o)
    {
        // ovo je izvedba polimorfizma
        Console.WriteLine(osoba.Pozdravi());
    }
}

// Tri klase Osoba, Predavač i Polaznik su pozornica za polimorfizam

pozdraviSve(osobe);
