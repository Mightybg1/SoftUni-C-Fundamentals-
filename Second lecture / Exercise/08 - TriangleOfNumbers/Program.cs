namespace _08___TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int actualNumber = int.Parse(Console.ReadLine());

            for(int i = 1; i <= actualNumber; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
