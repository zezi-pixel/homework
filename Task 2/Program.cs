namespace Task_2;


class Program
{
    static void Main(string[] args)
    {
        int secretNumber = 37;
        int guess = 0;
        int tries = 0;
        string input;

        Console.WriteLine("Guess the secret number from 1 to 100.");

        do
        {
            input = Console.ReadLine();

            if (int.TryParse(input, out guess) && guess >= 1 && guess <= 100)
            {
                tries++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine($"Correct! You found 37 in {tries} tries.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a whole number from 1 to 100.");
            }

        } while (guess != secretNumber);
    }
}
