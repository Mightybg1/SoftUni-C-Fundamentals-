namespace _11___Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double pricePerCapsule = 0;
            int days = 0;
            int capsulesCount = 0;
            double sum = 0;
            double total = 0;

            for (int i = 1; i <= orders; i++)
            {
                if (i > 0)
                {
                    pricePerCapsule = double.Parse(Console.ReadLine());
                    days = int.Parse(Console.ReadLine());
                    capsulesCount = int.Parse(Console.ReadLine());

                    sum = ((days * capsulesCount) * pricePerCapsule);

                    Console.WriteLine($"The price for the coffee is: {sum:f2}");
                }

                if (orders >= 1)
                {
                    total += sum;
                }
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
