namespace _03___GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double outFall4 = 39.99;
            double csog = 15.99;
            double zplinterZell = 19.99;
            double honored2 = 59.99;
            double roverWatch = 29.99;
            double roverWatchOriginsEdition = 39.99;


            double budget = double.Parse(Console.ReadLine());
            double spend = 0;
            string command = Console.ReadLine();


            while (command != "Game Time")
            {
                if (command == "OutFall 4")
                {
                    if (budget >= outFall4)
                    {
                        budget -= outFall4;
                        spend += outFall4;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (budget > 0 && budget < outFall4)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (budget <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "CS: OG")
                {
                    if (budget >= csog)
                    {
                        budget -= csog;
                        spend += csog;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (budget > 0 && budget < csog)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (budget <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "Zplinter Zell")
                {
                    if (budget >= zplinterZell)
                    {
                        budget -= zplinterZell;
                        spend += zplinterZell;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (budget > 0 && budget < zplinterZell)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (budget <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "Honored 2")
                {
                    if (budget >= honored2)
                    {
                        budget -= honored2;
                        spend += honored2;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (budget > 0 && budget < honored2)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (budget <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "RoverWatch")
                {
                    if (budget >= roverWatch)
                    {
                        budget -= roverWatch;
                        spend += roverWatch;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (budget > 0 && budget < roverWatch)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (budget <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (budget >= roverWatchOriginsEdition)
                    {
                        budget -= roverWatchOriginsEdition;
                        spend += roverWatchOriginsEdition;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (budget > 0 && budget < roverWatchOriginsEdition)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (budget <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");

                }


                command = Console.ReadLine();
                if (command == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${budget:f2}");

                }
            }
        }
    }
}
