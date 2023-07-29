int b = 0;
while (true)
{
    Console.Write("Unesi broj: ");

	try // try catch block - upišem try i dva puta tab
	{
		// ovdje uvijek dođe
		b=int.Parse(Console.ReadLine());
		break;
	}
	catch (Exception)
	{

        // ovdje dođe ako se je dogodila iznimka
        Console.WriteLine("Ne može");
    }

    
}

Console.WriteLine(b);
