// napišite metodu tipa int naziv KlasicnaMetoda
// koja prima parametar tipa int
// i vraća primljeni broj na kvadrat

using _01Lambda;

int KlasicnaMetoda(int b)
{
    return b * b;
}

// u konzolu napišite poziv definirate metode s parametrom 5

Console.WriteLine(KlasicnaMetoda(5));

// lambda expression
var kvadrat = (int b) => b*b;
Console.WriteLine(kvadrat(5));

// lambda statement 
var algoritam = (int x, int y) =>
{
    var t = x++ + --y;
    return x + y - t;
};

Console.WriteLine(algoritam(1,2));


int[] brojevi = { 22, 3, 4, 3, 4, 5, 6, };

// prebrojite koliko ima brojeva s vrijednošću 3 u nizu
// 2 

int ukupno = 0;
foreach (int k in brojevi)
{
    if (k == 3)
    {
        ukupno++;
    }
}
Console.WriteLine(ukupno);

Console.WriteLine(brojevi.Count(b => b==3)); // ova linija je ekvivalent kornjeg koda (od linije 33-41)


for(int i = 0; i < brojevi.Length; i++)
{
    Console.WriteLine(brojevi[i]);
}

Console.WriteLine("------------");

// ovaj kod odradi isti posao kao i kod iznad njega
foreach(int k in brojevi)
{
    Console.WriteLine(k);
}

Console.WriteLine("------------");

// ova linije mijenja i foreach iznad i for petlji iznad foreach-a
Array.ForEach(brojevi, Console.WriteLine);

Console.WriteLine("------------");


// ispisati svaki broj uvećan za 1
Array.ForEach(brojevi, b => 
{
    Console.WriteLine(b+1);
});

Console.WriteLine("------------");

// deklarirajte listu s slijedećim elementima: 2,3,4,5,4
var lista = new List<int>() { 2, 3, 4, 5, 4 };
lista.ForEach(Console.WriteLine);

Console.WriteLine("------------");

var smjerovi = new List<Smjer>()
{
    new () {Naziv = "Prvi", Sifra = 1},
    new () {Naziv = "Drugi", Sifra = 2},
};

smjerovi.ForEach(Console.WriteLine);

Console.WriteLine("------------");

smjerovi.ForEach(s =>
{
    int b = s.Sifra + new Random().Next();
    Console.WriteLine(s.Naziv + " " + b);
});

// string s = null; ako je null kad izvedem neće prikazati ništa
string s = "Edunova"; // program će ispisati Edunovb

Console.WriteLine(s?.Replace("a","b")); // ? radi da ako je null ostat će prazno, a bez ? program puca (NoReferenceExcpetion)
// ovo je dobro jer program neće pucati