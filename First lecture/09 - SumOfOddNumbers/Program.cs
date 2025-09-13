namespace _09___SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Input = int.Parse(Console.ReadLine());
            int Numbers = 1;
            int Sum = 0;

            for (int i = 1; i <= Input;)
            {
                if (Numbers % 2 == 1)
                {
                    Console.WriteLine(Numbers);
                    Sum += Numbers;
                    i++;
                }
                Numbers++;
            }
            Console.WriteLine($"Sum: {Sum}");

        }
    }
}
