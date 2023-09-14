using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello world";
        }

        [HttpGet]
        [Route("pozdrav")]
        public string DrugaMetoda()
        {
            return "Pozdrav svijetu";
        }

        [HttpGet]
        [Route("pozdravParametar")]
        public string DrugaMetoda(string s) // javlja crveno ako nema return
        {
            return "Hello " + s;
        }



        [HttpGet]
        [Route("pozdravViseParametara")]
        public string DrugaMetoda(string s="", int i = 0) // javlja crveno ako nema return
        {
            return "Hello " + s + " " + i;            
        }

        // kreirajte rutu /HelloWorld/zad1 koja ne prima parametre i vraća Vaše ime

        [HttpGet]
        [Route("zad1")]
        public string Zad()
        {
            return "Antonio";
        }

        // kreirajte rutu /HelloWorld/zad2 koja prima dva broja i vraća njihov zbroj

        [HttpGet]
        [Route("zad2")]
        public int Zbroj(int i, int j)
        {
            return i + j;
        }

        // kreirajte rutu /HelloWorld/zad3 koja prima parametar brojPonavljanja
        // ruta vraća niz znakova "Osijek" koji ima onoliko elemenata koliko smo primili u brojPonavljanja



        // DZ 
        // Kreirati rutu /HelloWorld/ciklicna
        // koja prima dva parametra (x i y) a vraća cikličnu matricu kao dvodimenzionalni niz brojeva

        [HttpGet]
        [Route("Ciklična")]
        public int[,] CiklicnaMatrica(int redaka, int stupaca)
        {
          

            int[,] matrica = new int[redaka, stupaca];
            int b = 1; //brojač
            string s;
            int a = 0;



            while (b <= redaka * stupaca)
            {
                //1
                for (int i = a + 1; i <= stupaca - a; i++)
                {
                    matrica[redaka - a - 1, stupaca - i] = b++;
                }


                //2
                for (int i = redaka - a - 2; i >= a; i--)
                {
                    matrica[i, a] = b++;
                }


                //3
                for (int i = a + 1; i <= stupaca - a - 1; i++)
                {
                    matrica[a, i] = b++;
                }

                //4
                for (int i = a + 1; i <= redaka - a - 2; i++)
                {
                    matrica[i, stupaca - a - 1] = b++;

                }


                a++;
            }
            // tablica
            for (int i = 0; i < redaka; i++)
            {
                for (int j = 0; j < stupaca; j++)
                {
                    s = "    " + matrica[i, j];
                    Console.Write(s[^4..]);
                }
                Console.WriteLine();
            }


            return matrica;
        }



    }
}