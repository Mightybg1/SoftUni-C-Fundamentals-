

namespace _12___EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());

            while (Number % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");  
                Number = int.Parse(Console.ReadLine());
            }
            if (Number < 0)
            {
                Number *= -1;
            }
            Console.WriteLine($"The number is: {Number}");
        }
    }
}
