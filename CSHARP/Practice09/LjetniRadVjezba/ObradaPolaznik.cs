using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRadVjezba
{
    internal class ObradaPolaznik // na engleskom Controller
    {
        public List<Polaznik> Polaznici { get; }


        public ObradaPolaznik()
        {
            Polaznici = new List<Polaznik>();
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Izbornik za rad sa polaznicima");
            Console.WriteLine("1. Pregled postojećih polaznika");
            Console.WriteLine("2. Unos novog polaznika");
            Console.WriteLine("3. Promjena postojećeg polaznika");
            Console.WriteLine("4. Brisanje polaznika");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Pomocno.UcitajBrojRaspon("Odaberite stavku izbornika polaznika: ", "Odabir mora biti od 1 - 5", 1, 5))
            {
                
                case 1:
                    PregledPolaznika();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UcitajPolaznika();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad sa polaznicima");
                    break;
            }


        }

        private void PregledPolaznika()
        {
            foreach(Polaznik polaznik in Polaznici)
            {
                Console.WriteLine(polaznik); // ne polaznik.ime itd. pa onda moram override method u Klasi Polaznik
            }
        }

        private void UcitajPolaznika() // unos novog polaznika
        {
            var p = new Polaznik();
            p.Ime = Pomocno.UcitajString("Unesi ime polaznika", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi prezime polaznika", "Prezime obavezno");
            // ostala svojstva kasnije
            Polaznici.Add(p); // obavezni dio => dodavanje polaznika na listu
        }
    }

    

}
