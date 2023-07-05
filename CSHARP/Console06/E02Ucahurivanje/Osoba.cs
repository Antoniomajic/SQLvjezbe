using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02Ucahurivanje
{
    internal class Osoba
    {

        // Učahurivanje
        // klasa će sakriti svoja svojstva
        private string ime;

        // klasa će učiniti svojstvo dostupnim putem tzv. get i set metoda
        public void setIme(string ime)
        {
            this.ime = ime;
        }

        public string getIme()
        {
            return this.ime;
        }

        // u nastavku nastave korisititi ćemo ovaj način za učahurivanje
        public string Prezime { get; set; }


        public Osoba()
        {

        }
    }
}
