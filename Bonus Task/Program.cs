namespace Bonus_Task;

class Program
{
    static void Main(string[] args)
    {
        int N = 0;
        int sum = 0;
        int reversed = 0;
        int original;
        do
        {
            N = int.Parse(Console.ReadLine());
            if (N<=0)
            {
                Console.WriteLine("Invalid number, try again.");
            }
        } while (N<=0);
        original = N;

        while (N > 0)
        {
            sum = sum + N % 10;
            reversed = reversed * 10 + N % 10;
            N = N / 10;
        }

        Console.WriteLine("Digit sum: " + sum);
        Console.WriteLine("Reversed: " + reversed);

        if (original == reversed)
        {
            Console.WriteLine("Palindrome: Yes");
        }
        else
        {
            Console.WriteLine("Palindrome: No");
        }
        
        
    }
}