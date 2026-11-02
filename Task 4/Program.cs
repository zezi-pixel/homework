namespace Task_4;


class Program
{
    static void Main(string[] args)
    {
        int budget = 0;
        int prices = 0;
        int spent = 0;
        int itemsBought = 0;
        string input;

        do
        {
            Console.WriteLine("Enter your budget:");
            input = Console.ReadLine();

            if (!int.TryParse(input, out budget) || budget <= 0)
            {
                Console.WriteLine("The budget must be a positive whole number.");
                budget = 0;
            }

        } while (budget <= 0);

        Console.WriteLine("Enter prices. Type \"pay\" when you are done.");

        do
        {
            input = Console.ReadLine();

            if (input != "pay")
            {
                if (!int.TryParse(input, out prices) || prices <= 0)
                {
                    Console.WriteLine("Invalid price.");
                }
                else if (prices > budget)
                {
                    Console.WriteLine($"Not enough money! You have {budget} EUR left.");
                }
                else
                {
                    budget = budget - prices;
                    spent = spent + prices;
                    itemsBought++;
                }
            }

        } while (input != "pay");

        Console.WriteLine($"You bought {itemsBought} items for {spent} EUR. Change: {budget} EUR.");
    }
}
