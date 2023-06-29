namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isMale = true;



            Console.WriteLine("1 ******************************");
            if (isMale)
            {
                Console.WriteLine("You are a male!");
            }
            else
            {
                Console.WriteLine("You are not a male!");
            }

            Console.WriteLine("2 ******************************");
            bool isTall = true;
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male!");
            }
            else
            {
                Console.WriteLine("You are not male or not tall or both!");
            }

            Console.WriteLine("3 ******************************");
            if (isMale ||  isTall)
            {
                Console.WriteLine("You are a tall male!");
            }
            else
            {
                Console.WriteLine("You are either a male or you are tall or both!");
            }

            Console.WriteLine("4 ******************************");
            if(isMale && isTall)
            {
                Console.WriteLine("You are a tall male!");
            }else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male!");
            }
            else
            {
                Console.WriteLine("You are either a male or you are tall or both!");
            }


            Console.WriteLine("5 ******************************");
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male!");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male!");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall!");
            }
            else
            {
                Console.WriteLine("You are neither male or tall");
            }




        }
    }
}
