Console.WriteLine("Unesi broj redaka: ");
int redaka = int.Parse(Console.ReadLine());

Console.WriteLine("Unesi broj stupaca: ");
int stupaca = int.Parse(Console.ReadLine());

int[,] matrica = new int[redaka, stupaca];
int b = 1; //brojač
string s;

// prvi red (redaka od iza)
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
Console.WriteLine("****************************1");

// drugi red (stupaca od dolje prema gore)
for (int i = redaka - 2; i >= 0; i--)
{
    matrica[i, 0] = b++;
}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("****************************2");


//// treći red (krećemo od matrica[0,1] i idemo sa lijeva na desno)
for (int i = 1; i <= stupaca - 1; i++)
{
    matrica[0, i] = b++;
}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("****************************3");

//// 4. idemo od zadnjeg stupca do dolje
for (int i = 1; i <= redaka - 2; i++)
{
    matrica[i, stupaca - 1] = b++;
}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("****************************4");
//treba dovršiti



