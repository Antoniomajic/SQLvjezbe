//  NIZOVI

int t1 = 2;
int t2 = 3;
int t3 = 12;
int t4 = 14;

// deklaracija niza
int[] niz;

// konstruiranje niza
niz= new int[3];

//dodijeljivanje vrijednosti
niz[0] = 0;
niz[1] =1;
niz[2] = 2;

Console.WriteLine(niz[2]);
Console.WriteLine(niz[^1]); // prvi od iza?
Console.WriteLine(niz[niz.Length-1]); // isto prvi od iza , a da je -2 bio bi drugi, itd.

// jednodimenzionalni nizovi
int[] podaci = { 2, 54, 45, 4, 5, 6, 3, 1, 2 };

// dvodimenzionalni niz
int[,] tablica = new int[3, 3]; // 9 podataka

// trodimenzionalni niz
int[,,] kocka = new int[3,3,3]; // 27 podataka

// višedimenzionalni nizovi do 32 dimenzije
