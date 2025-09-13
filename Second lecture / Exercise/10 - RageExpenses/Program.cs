namespace _10___RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headphonesPrice = double.Parse(Console.ReadLine());
            double moucePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = 0;
            int trashedMouce = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;

            for(int i = 1; i <= lostGames; i++)
            {
                if((double)i % 2 == 0)
                {
                    trashedHeadset++;
                }

                if ((double)i % 3 == 0)
                {
                    trashedMouce++;
                }

                if((double)i % 2 == 0 && (double)i % 3 == 0)
                {
                    trashedKeyboard++;
                }

                if((double)i % 12 == 0)
                {
                    trashedDisplay++;
                }
            }
            
            double price = (headphonesPrice * trashedHeadset) + (moucePrice * trashedMouce) + (keyboardPrice * trashedKeyboard) + (displayPrice * trashedDisplay);
            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}

            //for (double i = 0; i <= lostGames; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        trashedHeadset++;
            //    }
            //    for (int j = 0; j <= lostGames; j++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            trashedMouce++;
            //        }

            //        if (i % 2 == 0 && i % 3 == 0)
            //        {
            //            trashedKeyboard++;
            //        }

            //        if(trashedKeyboard % 2 == 0)
            //        {
            //            trashedDisplay++;
            //        }
            //    }
            //}