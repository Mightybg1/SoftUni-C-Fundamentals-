namespace _10___MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Input = int.Parse(Console.ReadLine());

            for( int i = 1; i<= 10; i++)
            {
                Console.WriteLine($"{Input} X {i} = {Input*i}");
            }
        }
    }
}
