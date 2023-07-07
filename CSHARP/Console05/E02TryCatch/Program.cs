using System.Xml;


int ucitajBroj()
{




    while (true)
    {
        Console.Write("Unesi broj: ");

        try // upišem try i dva puta tab = dobijem ovaj blok koda 
        {
            // uvijek dođe tu; a tu se smjesti neki kod od kojeg očekujemo da bi mogao baciti iznimku koda
            return int.Parse(Console.ReadLine());

        }
        catch (FormatException e) // ovdje dođe ako nije cijeli broj(int)
        {
            // ovdje dođe ako se dogodila iznimka
            // throw; // ovaj dio se obriše jer nam ne treba
            Console.WriteLine("Ne može");
        }
        catch (OverflowException e) // ovdje dođe ako je preveliki broj
        {
            Console.WriteLine("Ne pretjeruj");
        }
        catch (Exception e) // ovdje dođe za bilo koju iznimku ( no u ovome slučaju sve osim ove dvije gore)
        {
            Console.WriteLine("Ups, nešto nije dobro");
        }
        finally
        {
            // ovdje uvijek dolazi
            Console.WriteLine("Uspješno si unio broj");
        }



    }
}

int i = ucitajBroj();
int j = ucitajBroj();

Console.WriteLine(i + j);
