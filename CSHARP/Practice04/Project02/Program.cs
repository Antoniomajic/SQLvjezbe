class Program
{
    static void Main(string[] args)
    {
        SayHi("Mike",15);
        SayHi("John",33);
        SayHi("Sam",47);

        Console.WriteLine(cube(5));

        int cubedNumber = cube(5);
        Console.WriteLine(cubedNumber);

    }
    static void SayHi(string name, int age)
    {
        
        Console.WriteLine("Hello " + name + ", you are " + age + ".") ;
    }

    static int cube(int num)
    {
        int result= num*num*num;
        return result;
    }





}

