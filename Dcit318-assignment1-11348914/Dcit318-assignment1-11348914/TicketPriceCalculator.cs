using System;

public class TicketPriceCalculator
{
    public static void Run()
    {
        Console.Write("\nEnter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age >= 0)
            {
                decimal ticketPrice = CalculateTicketPrice(age);
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid age.");
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid age as a number.");
        }
    }

    static decimal CalculateTicketPrice(int age)
    {
        if (age >= 65 || age <= 12)
            return 7.00m;
        else
            return 10.00m;
    }
}
