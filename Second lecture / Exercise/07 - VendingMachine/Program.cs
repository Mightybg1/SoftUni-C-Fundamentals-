using System.Data.SqlTypes;
/*
1
1
0.5
0.6
Start
Coke
Soda
Crisps
End

 */

namespace _07___VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codeWord;
            codeWord = Console.ReadLine();
            double balance = 0;

            while (codeWord != "Start")
            {
                double money = double.Parse(codeWord);

                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    balance += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                codeWord = Console.ReadLine();
            }

            double nuts = 2;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1.0;

            string purchase;

            while ((purchase = Console.ReadLine()) != "End")
            {
                switch (purchase)
                {
                    case "Nuts":
                        if (balance >= nuts)
                        {
                            balance -= nuts;

                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (balance >= water)
                        {
                            balance -= water;

                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (balance >= crisps)
                        {
                            balance -= crisps;

                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (balance >= soda)
                        {
                            balance -= soda;

                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (balance >= coke)
                        {
                            balance -= coke;

                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;


                }
            }
            Console.WriteLine($"Change: {balance:F2}");

        }
    }
}
