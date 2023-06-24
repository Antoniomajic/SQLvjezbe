// SWITCH

int i = 2;


if (i == 1)
{
    Console.WriteLine("Dobro");
}else if (i == 2)
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("Ostalo");
}
// program će ispisati OK jer je taj if točan


// VIŠESTRUKO GRANANJE
int ocjena = 3;

switch (ocjena)
{
    case 1:
        Console.WriteLine("Nedovoljan");
        break;
    case 2:
        Console.WriteLine("Dovoljan");
        break;
    case 3:
        Console.WriteLine("Dobar");
        break;
    case 4:
        Console.WriteLine("Vrlo dobar");
        break;
    case 5:
        Console.WriteLine("Izvrstan");
        break;
    default:
        Console.WriteLine("Nije ocjena");
        break;            
}


/* Zadatak
 * Program unosi ime mjesta iz jedne od 4 slavonske županije
 * Za uneseno ime mjesta program ispisuje ime županije
 */

string grad = Console.ReadLine();   

switch (grad)
{
    case "Osijek":
        Console.WriteLine("Osječko-baranjska županija");
        break;
    case "Vukovar":
        Console.WriteLine("Vukovarsko-srijemska županija");
        break;
    case "Požega":
        Console.WriteLine("Požeško-slavonska županija");
        break;
    case "Slavonski Brod":
        Console.WriteLine("Brodsko-posavska županija");
        break;
    default:
        Console.WriteLine("Nije grad");
        break;
}