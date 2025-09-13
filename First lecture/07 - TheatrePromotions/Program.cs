namespace _07___TheatrePromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Day = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            int TicketPrice = 0;

            if(Day == "Weekday")
            {
                if(Age >= 0 && Age <= 18)
                {
                    TicketPrice = 12;
                    Console.WriteLine($"{TicketPrice}$");
                }
                else if (Age > 18 &&  Age <= 64)
                {
                    TicketPrice = 18;
                    Console.WriteLine($"{TicketPrice}$");
                }
                else if(Age > 64 && Age <= 122)
                {
                    TicketPrice = 12;
                    Console.WriteLine($"{TicketPrice}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            if(Day == "Weekend")
            {
                if (Age >= 0 && Age <= 18)
                {
                    TicketPrice = 15;
                    Console.WriteLine($"{TicketPrice}$");
                }
                else if (Age > 18 && Age <= 64)
                {
                    TicketPrice = 20;
                    Console.WriteLine($"{TicketPrice}$");
                }
                else if (Age > 64 && Age <= 122)
                {
                    TicketPrice = 15;
                    Console.WriteLine($"{TicketPrice}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            if (Day == "Holiday")
            {
                if (Age >= 0 && Age <= 18)
                {
                    TicketPrice = 5;
                    Console.WriteLine($"{TicketPrice}$");
                }
                else if (Age > 18 && Age <= 64)
                {
                    TicketPrice = 12;
                    Console.WriteLine($"{TicketPrice}$");
                }
                else if (Age > 64 && Age <= 122)
                {
                    TicketPrice = 10;
                    Console.WriteLine($"{TicketPrice}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            
        }
    }
}
