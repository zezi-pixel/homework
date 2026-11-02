namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        int busSeats = 50;
        int buses = 0;
        int students = 0;
        int freeSeats = 0;
        string input;

        do
        {
            Console.WriteLine("Enter the number of students:");
            input = Console.ReadLine();

            if (int.TryParse(input, out students) && students >= 1 && students <= 500)
            {
                buses = students / busSeats;

                if (students % busSeats != 0)
                {
                    buses++;
                }

                freeSeats = buses * busSeats - students;
            }
            else
            {
                Console.WriteLine("The number of students must be from 1 to 500.");
                students = 0;
            }

        } while (students == 0);

        if (freeSeats == 0)
        {
            Console.WriteLine($"You need {buses} buses. All buses are full.");
        }
        else
        {
            Console.WriteLine($"You need {buses} buses. The last bus has {freeSeats} free seats.");
        }
    }
}
