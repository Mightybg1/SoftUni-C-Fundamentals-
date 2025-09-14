namespace _02___EnglishNameOfLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int number2 = number % 10;

            if(number2 == 0)
            {
                Console.WriteLine("zero");  
            }
            else if (number2 == 1)
            {
                Console.WriteLine("one");
            }
            else if (number2 == 2)
            {
                Console.WriteLine("two");
            }
            else if(number2 == 3)
            {
                Console.WriteLine("three");
            }
            else if (number2 == 4)
            {
                Console.WriteLine("four");
            }
            else if (number2 == 5)
            {
                Console.WriteLine("five");
            }
            else if( number2 == 6)
            {
                Console.WriteLine("six");
            }
            else if(number2 == 7)
            {
                Console.WriteLine("seven");
            }
            else if(number2 == 8)
            {
                Console.WriteLine("eight");
            }
            else if(number2 == 9) 
            {
                Console.WriteLine("nine");
            }
        }
    }
}
