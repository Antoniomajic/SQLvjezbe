using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRadVjezba
{
    internal class ObradaGrupa
    {

        private List<Grupa> Grupe;

        private Izbornik Izbornik;



        public ObradaGrupa() 
        {

            Grupe = new List<Grupa>();
        }

        public ObradaGrupa(Izbornik izbornik): this() 
        {
            this.Izbornik = izbornik;
        }

        public void PrikaziIzbornik() // izbornik za smjerove
        {
            Console.WriteLine("Izbornik za rad sa grupama");
            Console.WriteLine("1. Pregled postojećih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena postojeće grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Pomocno.UcitajBrojRaspon("Odaberite stavku izbornika grupa: ", "Odabir mora biti od 1 - 5", 1, 5))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad sa grupama");
                    break;
            }
        }

        private void PrikaziGrupe()
        {
            foreach (Grupa grupa in Grupe)
            {
                Console.WriteLine("\t{0} ({1})", grupa.Naziv,grupa.Smjer.Naziv);
            }
        }

        private void UnosNoveGrupe()
        {
            var g = new Grupa();
            g.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifru grupe: ", "Unos mora biti pozitivni cijeli broj!");
            g.Naziv = Pomocno.UcitajString("Unesite naziv grupe: ", "Unos obavezan!");
            g.Smjer = UcitajSmjer();
            g.Polaznici = UcitajPolaznike();
            Grupe.Add(g);
        }

        private List<Polaznik> UcitajPolaznike()
        {
            List<Polaznik> polaznici = new List<Polaznik>();

            while(Pomocno.UcitajCijeliBroj("1 za dodavanje polaznika","Greška") == 1)
            {
                polaznici.Add(UcitajPolaznika());
            }

            return polaznici;
        }

        private Polaznik UcitajPolaznika()
        {
            Izbornik.ObradaPolaznik.PregledPolaznika();
            int broj = Pomocno.UcitajBrojRaspon("Odaberi redni broj polaznika za dodavanje u grupu", "Nije dobro", 1, Izbornik.ObradaPolaznik.Polaznici.Count());
            return Izbornik.ObradaPolaznik.Polaznici[broj - 1];
        }

        private Smjer UcitajSmjer()
        {
            Izbornik.ObradaSmjer.PrikaziSmjerove();
            int broj = Pomocno.UcitajBrojRaspon("Odaberi redni broj smjera za postavljanje na grupu", "Nije dobro", 1, Izbornik.ObradaSmjer.Smjerovi.Count());
            return Izbornik.ObradaSmjer.Smjerovi[broj - 1];
        }
    }
}
