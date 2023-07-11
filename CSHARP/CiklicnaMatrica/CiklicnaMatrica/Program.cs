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



    for (int i = 1; i <= stupaca; i++)
    {
        matrica[redaka - 1, stupaca - i] = b++;
    }


    //2
    for (int i = redaka - 2; i >= 0; i--)
    {
        matrica[i, 0] = b++;
    }


    //3
    for (int i = 1; i <= stupaca - 1; i++)
    {
        matrica[0, i] = b++;
    }

    //4
    for (int i = 1; i <= redaka - 2; i++)
    {
        matrica[i, stupaca - 1] = b++;

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

    






