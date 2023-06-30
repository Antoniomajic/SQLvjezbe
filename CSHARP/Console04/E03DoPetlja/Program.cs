// do petlja osigurava minimalno jedno izvođenje
// zato što je uvjet na kraju petlju

using System.Reflection.Metadata;

do
{
    Console.WriteLine("01 Ušao u petlju");
} while (false);

// ostalo sve kao u for i while

// Korisnik unosi dva cijela broja između 10 i 20
// Program ispisuje sve parne brojeve između unesenih brojeva
// Koristiti do petlju


Console.WriteLine("**************************");
int b1 = 0;

do
{
    Console.WriteLine("Unesi prvi cijeli broj: ");
    b1 = int.Parse(Console.ReadLine());
    if (b1 >= 10 && b1 <= 20)
    {
        break;
    }
    Console.Write("Nisi unio traženi broj! ");
} while (true);

int b2 = 0;
do
{
    Console.WriteLine("Unesi drugi cijeli broj: ");
    b2 = int.Parse(Console.ReadLine());
    if (b2 >= 10 && b2 <= 20)
    {
        break;
    }
    Console.Write("Nisi unio traženi broj! ");
} while (true);

int manji=b1<b2 ? b1 : b2;
int veci = b1 > b2 ? b1 : b2;

int i = manji;

do
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
} while (++i <= veci);


