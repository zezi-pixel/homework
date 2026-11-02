namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        int temperature = 0;
        int day = 0;
        int warmest = 0;
        int warmestDay = 0;
        string input;

        do
        {
            Console.WriteLine("Enter temperature");
            input = Console.ReadLine();

            if (input != "end")
            {
                temperature = int.Parse(input);
                day++;

                if (day == 1 || temperature > warmest)
                {
                    warmest = temperature;
                    warmestDay = day;
                }
            }

        } while (input != "end");

        Console.WriteLine($"Warmest: {warmest} degrees on day {warmestDay}.");
    }
}