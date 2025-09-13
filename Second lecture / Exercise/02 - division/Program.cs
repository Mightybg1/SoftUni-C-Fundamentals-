namespace _02___division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input % 10 == 0)
            {
                Console.WriteLine("The number is devisible by 10");
            }
            else if (input % 7 == 0)
            {
                Console.WriteLine("The number is devisible by 7");
            }
            else if (input % 6 == 0)
            {
                Console.WriteLine("The number is devisible by 6");
            }
            else if (input % 3 == 0)
            {
                Console.WriteLine("The number is devisible by 3");
            }
            else if (input % 2 == 0)
            {
                Console.WriteLine("The number is devisible by 2");
            }
            else
            {
                Console.WriteLine("Not devisible");
            }


            
        }
    }
}
