namespace Practice02 
{
    class Program
    { 
         static void Main(string[] args)
           {
            //Console.WriteLine("Hello World");

            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string firstName = "Mosh";
            //bool isWorking = false;

            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //const float Pi = 3.14f;
            Console.WriteLine("Insert a number: ");
            double r = Double.Parse(Console.ReadLine());
            double pi = 3.14;
            double o = 2 * r * pi;
            double p = r * r * pi;
            Console.WriteLine("o={0}, p={1}",o,p);

            
        }
    }
}
