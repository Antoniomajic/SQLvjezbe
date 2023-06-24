using System.ComponentModel;

Console.WriteLine("0. *************");          // koristim da bi na cmd-u jasnije vidio o kojem primjeru (zadatku) se radi
Console.WriteLine("Hello World");               // => ispisuje ''Hello World''
Console.WriteLine("Unesi ime grada: ");         // => ispisuje ''Unesi ime grada: ''
string ime = Console.ReadLine();                //=> deklaracija varijable tipa string koju sam nazvao ime
Console.WriteLine(ime);


// Primjer 1.
Console.WriteLine("1. *************");
Console.WriteLine("Tomislav");
Console.WriteLine("Edunova");
// Ove naredbe ispisuju Tomislav i Edunova, svaku u novom redu, 
Console.Write("Tomislav, Edunova\n"); //a da bi se ispisale jedna kraj druge (u istom retku) onda se koristi Console.Write kao u ovom primjeru
                                      // \n ide na kraju kako bih dodao novi red poslije "edunova"


// Komentar u jednoj liniji

/*
 * 
 * KOmentar 
 * u više linija
 */

/*
  A može 
    i ovako
*/


//DECIMALNI BROJEVI
float decimalniBroj = 3.14f;
double decimalniBrojVeci = 3.14;
decimal db = 3.14m;


Console.WriteLine("2. *************");
Console.WriteLine("decimalni broj: {0}\ndb: {1}", decimalniBroj, db); // {0} je oznaka za prvi

Console.WriteLine("3. *************");
// Na primjer
//                                                  {0}             {1}
Console.WriteLine("This {0}. The value is {1}.", "is a test", "Excellent");

// REZULTAT: This is a test. The value is Excellent. !!!!!!NE ZABORAVITI NAVODNIKE UNUTAR KOJI IDU INDEKSI (PLACEHOLDERS) -> {}



Console.WriteLine("4. *************");
Console.WriteLine(int.MinValue); //ispisuje najmanji broj int tipa podatka (-2147483648)
Console.WriteLine(int.MaxValue); //ispisuje najveći broj int tipa podatka (2147483648)

int b = int.MaxValue;   // varijabli b (tipa integer) dodijelili smo vrijednost maksimalna vrijednost (2147483648)

b = b + 1;              // pošto je b maksimalna vrijednost int tipa podatka, a dodavanjem +1 (uvećanjem za jedan) broj postaje -214... (kružnica od 0 do maks, pa onda prelazi na minus -214 sve do nule i tako u krug))

Console.WriteLine(b);


// 1. zadatak
// Deklarirajte 4 varijable različitih tipova podataka. Svakom od njih dodijelite vrijednost po želji. Sve ih odjednom ispišite jedno pored drugog
// Rješenje
Console.WriteLine("5. *************");
int broj1 = 15; bool tocno = true; string niz = "Niz znakova"; char z = 'A';
Console.WriteLine("{0},{1},{2},{3}", broj1, tocno, niz, z);

//Console.WriteLine(broj1);  ispisuje vrijednost varijeble broj1 (koja je int tip podatka, a dodijeljena vrijednost je 15
