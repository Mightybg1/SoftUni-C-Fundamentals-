namespace StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Grade = double.Parse(Console.ReadLine());

            if(Grade< 3.00)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
