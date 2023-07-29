using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// sivi su jer ih za sad ne koristimo

// metode su usko vezano uz klase
// u programu smo kucali metode int void, ništa posebno prije toga nije išlo (internal, private ...)

// internal omogućuje da vidiš klase unutar svog projekta
// public omogućuje da vide svi (van projekta, unutar),
// private je ekvivalent kao da ništa ne piše
// protected kad u nasljeđivanju vide podklase
// postoje još i neke kombinacije

namespace zajednickeMetode // naziv projekta u kojem radimo
{
    public class Metode // deklaracija klase
    {
        // OVA METODA SE MOŽE POZVATI NA INSTANCI KLASE
        public void ispis () // metoda tipa void naziva ispis; 0 references znači da nigdje nije pozvana
            // stavio sam public (može i internal) sad će se u drugoj klasi to morati vidjeti
        {
            Console.WriteLine("Hello");
            // sad idemo vidjeti kako ovoj metodi pristupiti iz programa

        }

        public void ispis(string poruka) // ovo je method overloading
        {
            Console.WriteLine(poruka);
        }

        public void ispis(int poruka)
        {
            Console.WriteLine(poruka);
        }



        // objekt ima sposobnost pohrane podataka
        // ako trebamo pamtiti stanje vrijednosti koristimo objekte
        // a ako ne , onda ćemo na metodi napraviti static

        // OVA METODA SE MOŽE POZVATI SA SAME KLASE

        /// <summary>
        /// Metoda zbraja dva primljena broja
        /// </summary>
        /// <param name="a">Prvi primljeni broj</param>
        /// <param name="b">Drugi primljeni broj</param>
        /// <returns>Zbroj dvaju primljenih brojeva</returns>
        public static int izracunaj(int a, int b)
        {
            return a + b;
        }                                                 


        // ova metoda će napraviti tablicu (matricu)
        public static void ispisiMatricu(int[,] matrica) // static znači da ne mora pamtiti nikakvo stanje
        {
            for(int i = 0; i < matrica.GetLength(0); i++)
            {
                for(int j= 0; j < matrica.GetLength(1);j++ )
                {
                    Console.Write(matrica[i,j] + " ");
                }
                Console.WriteLine();
            }

            string s = "";
            for(int i = 0; i < (matrica.GetLength(1) * 2)-1; i++)
            {
                s += "*";
            }
            Console.WriteLine(s);
        }


        // rekurzija je kada metoda poziva samu sebe uz uvjet prekida rekurzije                
        public static int faktorijel(int broj) // kod pisanja rekurzije uvijek prvo pišeš broj
        {
            if (broj == 1)
            {
                return broj;
            }
            return broj * faktorijel(broj-1);
        }


        // da bi mogli u svoj projekt učitat neki kod koji je zajednički kroz više projekata, taj projekt mora biti class library

    }
}



