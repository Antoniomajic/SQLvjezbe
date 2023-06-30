//int redaka = 5;
//int stupaca = 5;

Console.WriteLine("Unesi broj redova: ");
int redaka = int.Parse(Console.ReadLine());

Console.WriteLine("Unesi broj stupaca: ");
int stupaca = int.Parse(Console.ReadLine());

int[,] matrica = new int[redaka, stupaca];

// pripremljena je tablica, sve su nule
for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

// treba mi brojač
int b = 1;
Console.WriteLine("1***********************"); // ova je prazna
//matrica[redaka - 1, stupaca - 1] = b++;
//matrica[redaka - 1, stupaca - 2] = b++;
//matrica[redaka - 1, stupaca - 3] = b++;
//matrica[redaka - 1, stupaca - 4] = b++;
//matrica[redaka - 1, stupaca - 5] = b++;
//matrica[redaka - 1, stupaca - 6] = b++; -> OVO JE GREŠKA ZA 5*5


for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("2***********************"); // prvi red
for (int i = 1; i <= stupaca; i++)
{
    matrica[redaka - 1, stupaca - i] = b++;
}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}


for (int i = redaka - 2; i >= 0; i--)                       // od tud
{
    matrica[i, 0] = b++;
}

Console.WriteLine("3***********************"); // drugi red
for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}                                                           // do tud
                                                            // je cjelina


