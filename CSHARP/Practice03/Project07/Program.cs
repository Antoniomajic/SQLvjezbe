for (int i = 1; i <= 5; i++)
{
    for (int j = 0; j <= 5; j++)
    {
        Console.Write(i + j);
    }
    Console.WriteLine();
}


for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write("{0} ", (i + 1) * (j + 1));
    }
    Console.WriteLine();
}

string s;
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        var b = (i + 1) * (j + 1);
        s = "     " + b;
        Console.Write("{0}", s[^4..]);
    }
    Console.WriteLine();
}