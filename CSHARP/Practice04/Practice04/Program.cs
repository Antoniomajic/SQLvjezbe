// 1********************************
// prva vrsta metode je tipa void , ona ne prima parametre


// void znači da ta metoda ništa ne vraća;metode se pišu da se u njih ugradi neko zajedničko ponašanje koje će se više puta pozvati

// sada ćemo deklarirati metodu
using zajednickeMetode;

void Tip1()
{
    Console.WriteLine("Dobrodošli u program");
}

// ovo je poziv metode
Tip1();

// deklariranje metode bez poziva jednostavno neće izvesti tu metodu

// 2********************************
// drugi tip metode je tipa void, ali prima parametre

void Tip2(string poruka)
{
    Console.WriteLine(poruka);
}

// ova metoda prima varijablu, ovdje je varijabla parametar metode
// ona ispisuje ono što primi

Tip2("Ovo je vrijednost koju proslijeđujem");
// dakle u ovoj metodi smo odmah deklarirali varijablu string koja se zove poruka

// isto tako mogu reći 
string s = "Vrijednost varijable s";
Tip2(s);
// u prvom slučaju metodi sam odmah poslao string (pod nazovdnicima), nije bila u nekoj varijabli
// a u drugom slučaju neka vrijednost je bila u nekoj varijabli a ja metodi proslijedim tu varijablu, a metoda primi to kao poruku

// kada varijabla dođe u metodu ona se gleda onako kako ju je metoda deklarirala


string sa = "A ovo je vrijednost varijable sa";

Tip2(sa);

// 3********************************
//  TREĆI TIP METODE JE ODREĐENOG TIPA I NE PRIMA VRIJEDNOST
// ON VIŠE NIJE VOID, VEĆ INT, BOOL ITD. BILO KOJEG TIPA

int Tip3()
{
    return new Random().Next();
}
// napravi mi novu instancu klase random i na njoj mi pozovi metodu next ( ona ne prima parametre jer je u zagradi prazno, i ona je int tipa - to možemo provjeriti tako da mišem
// dođemo na nju

// kada je metoda nekog tipa mora imati ključnu riječ return; ona mora nešto vratiti

// overloads je preopterećenje metode

// poziv tip 3
Tip3(); // on će vratiti slučajni broj ali kod s tim brojem ništa ne radi

Console.WriteLine(Tip3()); // prvo se ulazi u unutranju zagradu - u ovom slučaju će naći neki nasumični broj i onda će metoda WriteLine to ispisati

// WriteLine može primiti i string i int i druge tipove podataka, tu se radi o tom overloadingu

int sb = Tip3();

Console.WriteLine(sb); 

// sada je rečeno slijedeće - tip3 nađe slučajni broj i vrati ga varijabli sb


// NAJBITNIJA I NAJZNAČAJNIJA METODA JE ČETVRTA
// ONA JE ODREĐENOG TIPA I PRIMA PARAMETRE

int Tip4(int min, int max)
{
    int manji = min < max ? min : max;
    int veci = max > min ? max : min;
    sb = 3; // iz metoda možemo pristupiti varijabli izvan metode (razina klase)
    //poruka = "asdf"; // ako je varijabla kao parametar metode jedne metode ne možemo ju vidjeti u drugoj metodi
    //return 0; // mora vratiti int nazad
    return new Random().Next(manji,veci); 
}

Console.WriteLine(Tip4(20,30));
Console.WriteLine(Tip4(-20,-30));



// specifičnost top-level statements načina

void ispis() //prima parametre dužine nula
{
    Console.WriteLine("Hello World!");
}

//void ispis(string poruka) // istog imena prima parametre dužine 1 (taj parametar je tipa string i naziv mu je poruka)
//{

//}

//identifikator metode nije samo naziv, već naziv + lista parametara



// imam klasu, treba mi njena instanca
// instanca klase Metode tj. objekt 
Metode m = new Metode();    

m.ispis();
m.ispis("12");
m.ispis(12);

Console.WriteLine(Metode.izracunaj(2,8));


int[,] t = new int[5,5];  

Metode.ispisiMatricu(t);

t[2, 4] = 7;

Metode.ispisiMatricu(t);


Console.WriteLine(Metode.faktorijel(5));

// kod rekurzije ne računa se u prvom prolazu već tek kad se dođe do uvjeta prekida, onda ona vraća nazad

