
namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        int hp = 0;
        int damage = 0;
        int hits = 0;
        string input;

        do
        {
            Console.WriteLine("Enter the boss HP:");
            input = Console.ReadLine();

            if (!int.TryParse(input, out hp) || hp < 1 || hp > 1000)
            {
                Console.WriteLine("Boss HP must be from 1 to 1000.");
                hp = 0;
            }

        } while (hp == 0);

        Console.WriteLine("Fight! Enter the damage of each attack.");

        while (hp > 0)
        {
            input = Console.ReadLine();

            if (!int.TryParse(input, out damage) || damage < 1 || damage > 100)
            {
                Console.WriteLine("Invalid attack! Damage must be from 1 to 100.");
                continue;
            }

            hits++;
            hp = hp - damage;

            if (hp < 0)
            {
                hp = 0;
            }

            Console.WriteLine($"Hit {hits}: -{damage} HP. Boss HP: {hp}");
        }

        Console.WriteLine($"Victory! The boss was defeated in {hits} hits.");
    }
}
