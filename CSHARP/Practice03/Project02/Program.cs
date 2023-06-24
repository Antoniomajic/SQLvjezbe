// Ulaz i Izlaz


//Ulaz
Console.WriteLine("1. *************");
Console.WriteLine("Unesite broj: ");
int broj=int.Parse(Console.ReadLine());

//algoritam
broj = broj + 7;

//Izlaz
Console.WriteLine(broj);
//npr. ako upišem 15 program će izbaciti 22 jer je algoritam izmjenio početnu vrijednost



//Program unosi dva decimalna broja; Program ispisuje njihov zbroj
Console.WriteLine("2. *************");
Console.WriteLine("Unesi dva decimalna broja: ");
double b1=double.Parse(Console.ReadLine()); 
double b2=double.Parse(Console.ReadLine()); 

double rez=b1+b2;
Console.WriteLine(rez);

//VAŽNO!! PRI UNOSU DECIMALNI BROJEVI STAVITI ZAREZ UMJESTO TOČKE


// KONVERZIJA
Console.WriteLine("3. *************"); //ovdje se radi o implicitnoj konverziji
float f = 7f;
double d = f;
Console.WriteLine(d);

//eksplicitna konverzija
f =float.Parse(d.ToString());

// CAST
int a = 3;
int b = 4;
float rez1 = a / (float)b;
Console.WriteLine("4. *************");
Console.WriteLine(rez1);

int br1 = 15;
//koja je prva znamenka broja?
Console.WriteLine("5. *************");
Console.WriteLine(br1/10);


// OPERATORI

// operatori uspoređivanja -> bool
Console.WriteLine("6. *************");
bool razlicito = 3 != 4;
bool vece = 8 > 6;
Console.WriteLine("{0},{1}",razlicito,vece);

// logički operatori -> učimo kod if naredbe
Console.WriteLine("7. *************");
bool rez2=razlicito & vece;
Console.WriteLine(rez2);

// operator + ima dvojaku ulogu
Console.WriteLine("8. *************");
string s = "Edunova" + "Osijek"; // ovdje ima ulogu nadoljepljivanja
int x = 6 + 2; // ovdje zbraja
string s1 = "Broj " + 5;
Console.WriteLine(s1);

// operator modulo ostatak nakon cjelobrojnog djeljenja
// školski primjer je parni i neparni

// Za uneseni broj ispiši True ako je parni ili False ako je neparni
Console.WriteLine("9. *************");
Console.WriteLine("Unesi broj: ");
x=Int16.Parse(Console.ReadLine());  

Console.WriteLine(x%2==0); // % je znak za modulo = to znači da je x npr. parni broj (8) podijeljno sa dva daje 4 i neostaje nikakav ostatak
                           // dok je 9 / 2 = daje 4 i 1 ostatak (jer 4*2=8 plus taj jedan ostatak)
                           // što znači da je u tom slučaju ==1 a ne ==0 tako je onda false 
                           // jer se radi o bool tipu podatka

// Deklarirajte varijablu tipa int naziva negativniBroj i dodijelite joj vrijednost -262
// ispišite pozitivni ekvivalent negativniBroj

Console.WriteLine("10. *********");
int negativniBroj = -262;
Console.WriteLine(negativniBroj * -1); // rješenje: negativni broj podijelimo sa negativnim brojem (u ovom slučaju -1 jer želimo taj isti broj) kako bismo dobili pozitivni broj

// Za unesena dva cijela broja 
// ispišite rezultat dijeljenja
// npr. ulaz 5 i 10, izlaz 0,5

Console.WriteLine("11. *********");
Console.WriteLine("Unesi prvi cijeli broj: ");
int br3=int.Parse(Console.ReadLine());
Console.WriteLine("Unesi drugi cijeli broj: ");
int br4=int.Parse(Console.ReadLine());
Console.WriteLine(br3/(double)br4); // može i float umjesto double; NA OVAJ NAČIN OD DVA CIJELA BROJA DOBIJELO DECIMALNI

// Za uneseni dvoznamenkasti broj 
// ispišite jediničnu vrijednost
// unos 21, ispis 1
// unos 87, ispis 7

Console.WriteLine("12. **********");
Console.WriteLine("Unesi dvoznamenkasti broj: ");
int br5=int.Parse(Console.ReadLine());
Console.WriteLine(br5%10); // modulo vraća ostatak



