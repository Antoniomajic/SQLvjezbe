int i = 2;

if(i==1)
{
    Console.WriteLine("Dobro");
}else if (i==2)
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("Ostalo");
}

// višestruko grananje 
int ocjena = 3;

switch(ocjena)
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


//1. zadatak = Program unosi ime mjesta iz 1 od 4 slavonske županije; Za uneseno ime mjesta program ispisuje ime županije

Console.WriteLine("Unesi ime mjesta: ");
string mjesto  = Console.ReadLine();    

switch(mjesto)
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
    default : Console.WriteLine("Nije naziv mjesta");
        break;

}