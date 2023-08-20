using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRadVjezba
{
    internal class Izbornik
    {
        private ObradaSmjer ObradaSmjer;
        private ObradaPolaznik ObradaPolaznik; // deklariram

        public Izbornik() // konstruktor
        {
            ObradaSmjer = new ObradaSmjer();
            ObradaPolaznik = new ObradaPolaznik(); // konstruiram
            PozdravnaPoruka(); //poziv metode
            PrikaziIzbornik(); //poziv metode
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Edunova Console APP v 1.0 *****");
            Console.WriteLine("*************************************");            
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Izlaz iz programa");

            switch(Pomocno.UcitajBrojRaspon("Odaberite stavku izbornika: ", "Odabir mora biti od 1 do 4", 1, 4))
            {
                case 1:
                    ObradaSmjer.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.WriteLine("Rad sa grupama");
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("Hvala na korištenju, doviđenja");
                    break;
            }

        }
    }
}
