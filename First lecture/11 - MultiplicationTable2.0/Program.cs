namespace _11___MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Input = int.Parse(Console.ReadLine());
            int Multiplier = int.Parse(Console.ReadLine());

            for(int i = Multiplier; i <= 10;)
            {
                Multiplier = i;
                Console.WriteLine($"{Input} X {Multiplier} = {Input * Multiplier}");
                i++;
            }
                if(Multiplier > 10)
                {
                    Console.WriteLine($"{Input} X {Multiplier} = {Input * Multiplier}");
                }
        }
    }
}
