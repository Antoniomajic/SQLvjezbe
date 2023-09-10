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





    }
}