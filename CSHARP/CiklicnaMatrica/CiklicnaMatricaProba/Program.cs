using System.ComponentModel.Design;

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



while(b< stupaca * redaka)
{
    for (int i = 1; i <= stupaca; i++)
    {
        if (b <= redaka * stupaca)
            matrica[redaka - 1, stupaca - i] = b++;
        else break;

    }


    for (int i = redaka - 2; i >= 0; i--)
    {
        if (b <= redaka * stupaca)
            matrica[i, 0] = b++;
        else break;

    }



    for (int i = 1; i <= stupaca - 1; i++)
    {
        if (b <= redaka * stupaca)
            matrica[0, i] = b++;
        else break;

    }

    for (int i = 1; i <= redaka - 2; i++)
    {
        if (b <= redaka * stupaca)
            matrica[i, stupaca - 1] = b++;
        else break;


    }




    for (int i = 0; i < redaka; i++)
    {
        for (int j = 0; j < stupaca; j++)
        {
            s = "    " + matrica[i, j];
            Console.Write(s[^4..]);
        }
        Console.WriteLine();
    }

}
