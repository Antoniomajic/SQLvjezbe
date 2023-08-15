int ucitajBroj()
{
    while (true)
    {
        Console.WriteLine("Unesi broj: ");

        try
        {
            // ovdje uvijek dođe
            return int.Parse(Console.ReadLine());
        }
        catch (FormatException e)  
        {
            // ovdje dođe ako se dogodila iznimka FormatException
            Console.WriteLine("Ne može");


        }

        catch(OverflowException e) 
        {
            // ovdje dođe ako se dogodila iznimka OverflowException
            Console.WriteLine("Ne pretjeruj!");
        }

        catch (Exception)
        {
            // ovdje dođe za bilo koju iznimku
            Console.WriteLine("Ooooops, nešto nije dobro");
        }
        finally
        {
            // ovdje uvijek dolazi
        }



    }
}


int i = ucitajBroj();
int j = ucitajBroj();

Console.WriteLine(i + j) ;