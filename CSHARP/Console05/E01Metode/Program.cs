// postoji 5 vrsta metoda

// prva vrsta metode je tipa void = ne prima parametre

// deklaracija metode
using ZajednickeMetode;

void Tip1()  // void znači da metoda ništa ne vraća (void - praznina)
{
    Console.WriteLine("Dobrodošli u program");
}

// poziv metode
//Tip1();

// kada izvedemo on će ispisati "Dobrodošli u program"

// deklariranje metode bez poziva znači da se ona neće izvesti

// drugi tip je void, ali prima parametre, tu je varijabla parametar metode

void Tip2(string poruka)
{
    Console.WriteLine(poruka); // ona ispisuje ono što primi
}

Tip2("Ovo je vrijednost koju proslijeđujem"); // metodi odmah šaljem u navodnicima string

string s = "Vrijednost varijable s"; // vrijednost u varijabli
Tip2(s); // ovdje sam varijablu proslijedio metodi, u ovom slučaju kao poruku

// treći tip metode - određenog tipa, ne prima vrijednost
// on više nije void, on će biti bilo kojeg tipa (int, double, array itd.)
int Tip3()
{
    // javljati će grešku ako nema return(jer ona mora nešto vratiti)
    return new Random().Next();
}

Tip3(); // on će vratiti slučajni broj ali kod s tim brojem kod ništa ne radi

Console.WriteLine(Tip3()); // prvo se izvodi Tip3, tu će naći neki random broj i onda će tu vrijednost VRATITI metodi WriteLine

int sb = Tip3();
Console.WriteLine(sb);

// NAJBITNIJA METODA = 4. METODA ODREĐENOG TIPA I PRIMA PARAMETRE

int Tip4(int min, int max)
{
    int manji = min < max ? min : max;
    int veci = max > min ? max : min; // sad u metodi provjeravam da li si mi dao veći, manji
    sb = 3; // vidimo varijablu jer je izvan metode (razina klase)
    //poruka = ""; ako je varijabla parametar jedne metode, tu varijablu ne možemo vidjeti u drugoj metodi
    return new Random().Next(manji, veci); // ovo stavimo da nema sintakse greške, a u ovom slučaju mora ići 0 tj. broj jer ako stavimo "" javit će grešku jer je metoda tipa int , kasnije sam promijeo na random... 
}

Console.WriteLine(Tip4(20, 30));
Console.WriteLine(Tip4(-20, -30));

// specifičnost top-level statements načina

void ispis() // metoda tipa void , naziva ispis, kaže se prima parametre dužine nula
{
    Console.WriteLine("Hello world");
}

//void ispis(string poruka) // isti naziv, ali ova prima neke parametre, tj. jedan; ova je metoda primila parametre dužina jedan tipa string ,a naziv mu je poruka
//{

//} 


// instanca klase Metode
Metode m = new Metode();

m.ispis();
m.ispis("12");
m.ispis(12);

// reći će hello jer sam iz program.cs kreirao instancu klase metode i na njoj pozvao ispis (koji je ispisao hello)

Console.WriteLine(Metode.izracunaj(2, 8));

int[,] t = new int[5, 5];

Metode.ispisiMatricu(t);

t[2, 4] = 7;



Metode.ispisiMatricu(t);



Console.WriteLine(Metode.faktorijel(5));