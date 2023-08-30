int redaka, stupaca;

Console.WriteLine("Welcome to the program!");

Console.Write("Please insert the number of rows: ");
redaka = int.Parse(Console.ReadLine());

Console.Write("Now insert the number of columns: ");
stupaca = int.Parse(Console.ReadLine());

Console.WriteLine("*********************************");

int[,] matrica = new int[redaka, stupaca];
int b = 1; //brojač
string s;
int a = 0;



while (b <= redaka * stupaca)
{
    //1
    for (int i = a + 1; i <= stupaca - a; i++)
    {
        matrica[redaka - a - 1, stupaca - i] = b++;
    }


    //2
    for (int i = redaka - a - 2; i >= a; i--)
    {
        matrica[i, a] = b++;
    }


    //3
    for (int i = a + 1; i <= stupaca - a - 1; i++)
    {
        matrica[a, i] = b++;
    }

    //4
    for (int i = a + 1; i <= redaka - a - 2; i++)
    {
        matrica[i, stupaca - a - 1] = b++;

    }


    a++;
}
// tablica
for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        s = "    " + matrica[i, j];
        Console.Write(s[^4..]);
    }
    Console.WriteLine();
}