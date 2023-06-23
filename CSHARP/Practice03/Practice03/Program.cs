/* VJEŽBA
 * Za unesena dva cijela broja
 * program ispisuje veći
 * 3 i 5 ->5
 * 5 i 3 -> 5
 * 5 i 5 ->
 */

Console.WriteLine("1. ************");
Console.WriteLine("Unesi prvi broj: ");
int br5 = int.Parse(Console.ReadLine());
Console.WriteLine("Unesi drugi broj");
int br6 = int.Parse(Console.ReadLine());
if (br5 > br6)
{
    Console.WriteLine(br5);
}
else if (br6 > br5)
{
    Console.WriteLine(br6);
}
else
{

}

/* VJEŽBA 2
 * Za upisana 3 cijela broja
 * program ispisuje najveći
 */

Console.WriteLine("2. ************");
Console.WriteLine("Unesi prvi broj: ");
int br1 = int.Parse(Console.ReadLine());
Console.WriteLine("Unesi drugi broj: ");
int br2 = int.Parse(Console.ReadLine());
Console.WriteLine("Unesi treći broj: ");
int br3 = int.Parse(Console.ReadLine());

if (br1 > br2 && br1 > br3)
{
    Console.WriteLine(br1);
}
else if (br2 > br1 && br2 > br3)
{
    Console.WriteLine(br2);
}
else
{
    Console.WriteLine(br3);
}

/* VJEŽBA 3. 
 * Program unosi broj između 1 i 999
 * U slučaju da je izvan tog raspona ispisati grešku i prekinuti program
 * Program ispisuje 1. znamenku upisanog broja
 */


Console.WriteLine("3. ************");
Console.WriteLine("Unesi broj: ");
int br4 = int.Parse(Console.ReadLine());

if (br4 < 1 || br4 > 999)
{
    Console.WriteLine("Greška");
}
else if (br4 < 10)
{
    Console.WriteLine(br4);
}
else if (br4 < 100)
{
    Console.WriteLine(br4 / 10);
}
else if (br4 < 1000)
{
    Console.WriteLine(br4 / 100);
}


/* VJEŽBA 4.
 * Program unosi 2 broja
 * Ako su oba broja parni ispisuje njihov zbroj
 * inače ispisuje njihovu razliku
 */

Console.WriteLine("4. ************");
Console.WriteLine("Unesi prvi broj: ");
int br7 = int.Parse(Console.ReadLine());
Console.WriteLine("Unesi drugi broj");
int br8 = int.Parse(Console.ReadLine());
int zbroj = br7 + br8;
int razlika = br7 - br8;

if (br7 % 2 == 0 && br8 % 2 == 0)
{
    Console.WriteLine(zbroj);
}
else
{
    Console.WriteLine(razlika);
}

