namespace _09___PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double percent = (double)students * 10 / 100;
            double allSabers = students + Math.Ceiling(percent);
            double sabers = priceOfLightsaber * allSabers;

            double robes = priceOfRobe * students;

            double beltsDiscount = students - students / 6;
            double belts = priceOfBelt * beltsDiscount;

            double total = sabers + robes + belts;

            if (total <= moneyAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - moneyAmount:f2}lv more.");
            }
        }
    }
}
