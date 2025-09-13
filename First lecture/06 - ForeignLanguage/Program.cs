namespace _06___ForeignLanguage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Country = Console.ReadLine();

            switch (Country)
            {
                case "USA" or "England":
                    Console.WriteLine("English");
                    break;
                case "Spain" or "Argentina" or "Mexico":

                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
