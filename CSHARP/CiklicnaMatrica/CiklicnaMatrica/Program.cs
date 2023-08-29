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


/* b je brojač, to jest "broj" koji se svakim korakom uvećava (svaka "pozicija" u tablici, ako je tablica npr. 2x2 onda imamo četiri "polja"
 * s tim da je svako slijedeće uvećano za 1 
 * 
 * int a u svakoj petlji ima ulogu da uđe u slijedeći "krug" nakon što b "dođe" do posljednje fiksne pozicije (na četvrtoj petlji)
 * na početku ostajemo u prvom krugu jer je a=0, a onda se u slijedećoj interaciji a povećava na 1 pa 2... itd.
*/ 


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

    
    a++; // OVO JE KLJUČNO JER SE SVAKI PUT KAD ODRADI PETLJE OD 1-4 VRATI UVEĆAN ZA JEDAN!!!
         // I STAJE ONDA KADA je b manji od zbroja redaka i stupaca
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





