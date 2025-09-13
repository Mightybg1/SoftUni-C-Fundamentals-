namespace _04___BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int MinuteOver60 = 60;

            minutes = minutes + 30;

            if(minutes >= MinuteOver60)
            {
                MinuteOver60 = minutes - MinuteOver60;
                hours++;
                
                minutes = MinuteOver60;
            }
            if(hours > 23)
            {
                hours = 0;

            }



            
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
