Console.WriteLine("Unesi broj redaka: ");
int redaka = int.Parse(Console.ReadLine());

Console.WriteLine("Unesi broj stupaca: ");
int stupaca = int.Parse(Console.ReadLine());

int[,] matrica = new int[redaka, stupaca];
int b = 1; //brojač

// prvi red (redaka od iza)
for (int i = 1; i <= stupaca; i++)
{
    matrica[redaka - 1, stupaca - i] = b++;
}

for (int i = 0; i < redaka; i++) // ovo je uvijek isto
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("****************************");

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
Console.WriteLine("****************************");

// treći red (redaka ka više)
