using System.Runtime.ExceptionServices;

namespace ZajednickeMetode // namespace je naziv projekta na kojem radim
{
    public class Metode // deklaracija klase 
    {
        // metoda tipa void,nazvat ćemo ju ispis
        // ova metoda se može na instanci klase
        public void ispis() // 0 references znači da ju nitko niju pozvao na nekom drugom mjestu
        {
            Console.WriteLine("Hello");
        }


        public void ispis(string poruka)
        {
            Console.WriteLine(poruka);
        }

        public void ispis(int poruka)
        {
            Console.WriteLine(poruka);
        }


        // ova metoda se  može pozvati sa same klase
        /// <summary>
        /// Metoda zbraja dva primljena broja
        /// </summary>
        /// <param name="a">"Prvi primljeni broj</param>
        /// <param name="b">Drugi primljeni broj</param>
        /// <returns>Zbroj dvaju primljenih brojeva</returns>
        // summary dobijem tako da stavim tri komada/
        public static int izracunaj(int a, int b)
        {
            return a + b;
        }


        public static void ispisiMatricu(int[,] matrica)
        {
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    Console.Write(matrica[i, j] + " ");
                }
                Console.WriteLine();
            }
            string s = "";
            for (int i = 0; i < (matrica.GetLength(1) * 2) - 1; i++)
            {
                s += "*";
            }
            Console.WriteLine(s);
        }



        // rekurzija je kada metoda poziva samu sebe uz uvjet prekida rekurzije


        public static int faktorijel(int broj)
        {
            if (broj == 1) // uvijek prvo pišeš uvjet
            {
                return broj;
            }
            return broj * faktorijel(broj - 1); // 5 nije jedan pa ide 4 * (broj-1=4)
        }



    }
}
