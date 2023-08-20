using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRadVjezba
{
    internal class ObradaSmjer // razina klase
    {
        // tu opet trebaju get i set
        public List<Smjer> Smjerovi { get; }


        public ObradaSmjer() // konstruktor
        {
            Smjerovi = new List<Smjer>();

            if (Pomocno.DEV)
            {
                TestniPodaci();
            }
            
            
        }    

        public void PrikaziIzbornik() // izbornik za smjerove
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Izbornik za rad sa smjerovima");
            Console.WriteLine("1. Pregled postojećih smjerova");
            Console.WriteLine("2. Unos novog smjera");
            Console.WriteLine("3. Promjena postojećeg smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch(Pomocno.UcitajBrojRaspon("Odaberite stavku izbornika smjera: ", "Odabir mora biti od 1 - 5", 1, 5))
            {
                case 1:
                    PrikaziSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogSmjera();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjenaSmjera();
                    PrikaziIzbornik();
                    break;
                case 4:
                    if(Smjerovi.Count == 0)
                    {
                        Console.WriteLine("Nema smjerova za brisanje");

                    }
                    else
                    {
                        BrisanjeSmjera();
                    }

                    
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad sa smjerovima");
                    break;
            }
        }

        private void BrisanjeSmjera()
        {
            PrikaziSmjerove();
            int broj = Pomocno.UcitajBrojRaspon("Odaberi redni broj smjera za brisanje", "Nije dobro", 1, Smjerovi.Count());
            Smjerovi.RemoveAt(broj - 1);
        }

        private void PromjenaSmjera()
        {
            PrikaziSmjerove();
            int broj = Pomocno.UcitajBrojRaspon("Odaberi redni broj smjera za promjenu", "Nije dobro", 1, Smjerovi.Count());
            var s = Smjerovi[broj - 1];
            s.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifru smjera (" + s.Sifra + "): ", "Unos mora biti pozitivni cijeli broj!");
            s.Naziv = Pomocno.UcitajString("Unesite naziv smjera(" + s.Naziv + "): ", "Unos obavezan!");
            s.Trajanje = Pomocno.UcitajCijeliBroj("Unesi trajanje smjera u satima(" + s.Naziv + "): ", "Unos mora biti cijeli pozitivni broj!");
        }

        private void UnosNovogSmjera()
        {
            var s = new Smjer();
            s.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifru smjera: ", "Unos mora biti pozitivni cijeli broj!");
            s.Naziv = Pomocno.UcitajString("Unesite naziv smjera: ", "Unos obavezan!");
            s.Trajanje = Pomocno.UcitajCijeliBroj("Unesi trajanje smjera u satima: ", "Unos mora biti cijeli pozitivni broj!");
            // ostala svojstva kasnije
            Smjerovi.Add(s);
        }

        public void PrikaziSmjerove()
        {
            Console.WriteLine();
            Console.WriteLine("---- Dostupni smjerovi -------");
            Console.WriteLine("------------------------------");
            int b = 1;
            foreach(Smjer smjer in Smjerovi) 
            {
                Console.WriteLine("\t{0}. {1}",b++,smjer.Naziv);
            }
            Console.WriteLine("------------------------------");
        }

        private void TestniPodaci()
        {
            Smjerovi.Add(new Smjer { Naziv = "Web programiranje"});
            Smjerovi.Add(new Smjer { Naziv = "Java programiranje" });
            Smjerovi.Add(new Smjer { Naziv = "Web dizajn" });
        }

    }
}
