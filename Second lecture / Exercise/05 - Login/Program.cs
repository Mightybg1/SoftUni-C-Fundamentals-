namespace _05___Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = new string(user.Reverse().ToArray());

            for (int i = 1; i <= 4; i++)
            {
                string passwordAttempt = Console.ReadLine();
                if (passwordAttempt != password && i <= 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (passwordAttempt == password)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }
            }
        }
    }
}
