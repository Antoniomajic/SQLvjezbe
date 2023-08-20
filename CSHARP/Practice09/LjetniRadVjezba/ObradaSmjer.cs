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
            TestniPodaci();
            
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
                case 5:
                    Console.WriteLine("Gotov rad sa smjerovima");
                    break;
            }
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

        private void PrikaziSmjerove()
        {
            foreach(Smjer smjer in Smjerovi) 
            {
                Console.WriteLine(smjer.Naziv);
            }
        }

        private void TestniPodaci()
        {
            Smjerovi.Add(new Smjer { Naziv = "Web programiranje"});
        }

    }
}
