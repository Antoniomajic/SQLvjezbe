int t1 = 2;
int t2 = 3;
int t3 = 12;
int t4 = 14;



// deklaradcija niza
int[] niz;

// konstruiranje niza

niz = new int[3];

niz[0] = 2;
niz[1] = 1;
niz[2] = 3;

Console.WriteLine(niz[2]);
Console.WriteLine(niz[^1]); // prvi odozada
Console.WriteLine(niz[niz.Length-1]); // daje isti rezultat kao i ovaj gore ^. daje prvi od iza

int[] podaci = { 2, 3, 23, 2, 2, 2, 3, 3, 22 };
Console.WriteLine(podaci[podaci.Length-1]);
Console.WriteLine(podaci[2]);

// dvodimenzionalni niz
int[,] tablica = new int[3, 3]; // 9 podataka

// trodimenzionalni niz
int[,,] kocka = new int[3, 3, 3]; // 27 podataka

// višedimenzionalni nizovi do 32 dimenzije