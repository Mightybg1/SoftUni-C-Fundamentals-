namespace _03___Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double ticketPrice = 0;
            double sum = 0;

            switch (dayOfTheWeek)
            {
                case "Friday":
                    if (groupType == "Students")
                    {
                        ticketPrice = 8.45;
                        sum = ticketPrice * groupOfPeople;

                        if (groupOfPeople >= 30)
                        {
                            sum = sum - (sum * 0.15);
                        }
                    }
                    else if (groupType == "Business")
                    {
                        ticketPrice = 10.90;
                        sum = ticketPrice * groupOfPeople;

                        if (groupOfPeople >= 100)
                        {
                            sum = sum - (ticketPrice * 10);
                        }
                    }
                    else if (groupType == "Regular")
                    {
                        ticketPrice = 15;
                        sum = ticketPrice * groupOfPeople;

                        if (groupOfPeople >= 10 && groupOfPeople <= 20)
                        {
                            sum = sum - (sum * 0.05);
                        }
                    }
                    break;
                case "Saturday":
                    if (groupType == "Students")
                    {
                        ticketPrice = 9.80;
                        sum = ticketPrice * groupOfPeople;

                        if(groupOfPeople >= 30)
                        {
                            sum = sum - (sum * 0.15);
                        }
                    }
                    else if (groupType == "Business")
                    {
                        ticketPrice = 15.60;
                        sum = ticketPrice * groupOfPeople;

                        if(groupOfPeople >= 100)
                        {
                            sum = sum - (ticketPrice * 10);
                        }
                    }
                    else if (groupType == "Regular")
                    {
                        ticketPrice = 20;
                        sum = ticketPrice * groupOfPeople;

                        if(groupOfPeople >= 10 && groupOfPeople <= 20)
                        {
                            sum = sum - (sum * 0.05);
                        }
                    }
                    break;
                case "Sunday":
                    if (groupType == "Students")
                    {
                        ticketPrice = 10.46;
                        sum = ticketPrice * groupOfPeople;

                        if (groupOfPeople >= 30)
                        {
                            sum = sum - (sum * 0.15);
                        }
                    }
                    else if (groupType == "Business")
                    {
                        ticketPrice = 16;
                        sum = ticketPrice * groupOfPeople;

                        if (groupOfPeople >= 100)
                        {
                            sum = sum - (ticketPrice * 10);
                        }
                    }
                    else if (groupType == "Regular")
                    {
                        ticketPrice = 22.50;
                        sum = ticketPrice * groupOfPeople;

                        if (groupOfPeople >= 10 && groupOfPeople <= 20)
                        {
                            sum = sum - (sum * 0.05);
                        }
                    }
                    break;
                    
            }
            Console.WriteLine($"Total price: {sum:f2}");
            /*
                 
               ! check what group they are
               !  check sum the total
                add discount if needed to the total
            
             
             */




        }
    }
}

//if (dayOfTheWeek == "Friday")
//{
//    if (groupType == "Students")
//    {
//        ticketPrice = 8.45;

//        //if (groupOfPeople >= 30)
//        // {

//        // }
//    }
//    else if (groupType == "Business")
//    {
//        ticketPrice = 10.90;

//        // if (groupOfPeople > 100)
//        //{

//        // }
//    }
//    else if (groupType == "Regular")
//    {
//        ticketPrice = 15;
//    }

//    sum = ticketPrice * groupOfPeople;

//    if (groupOfPeople >= 30)
//    {
//        sum *= 0.15;
//    }


//}
//else if (dayOfTheWeek == "Saturday")
//{
//    if (groupType == "Students")
//    {
//        ticketPrice = 9.80;

//        if (groupOfPeople > 30)
//        {
//            ticketPrice = (ticketPrice / 20) + (ticketPrice / 10);
//        }
//    }
//    else if (groupType == "Business")
//    {
//        ticketPrice = 15.60;
//    }
//    else if (groupType == "Regular")
//    {
//        ticketPrice = 20;
//    }
//}
//else if (dayOfTheWeek == "Sunday")
//{
//    if (groupType == "Students")
//    {
//        ticketPrice = 10.46;


//    }
//    else if (groupType == "Business")
//    {
//        ticketPrice = 16;
//    }
//    else if (groupType == "Regular")
//    {
//        ticketPrice = 22.50;
//    }

//    sum = ticketPrice * groupOfPeople;

//    if (groupOfPeople >= 30)
//    {
//        sum *= 0.15;
//    }
//}





//Console.WriteLine($"Total price: {sum}");