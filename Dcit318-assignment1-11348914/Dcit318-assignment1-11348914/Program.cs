using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== DCIT318 Assignment Menu =====");
        Console.WriteLine("1. Grade Calculator");
        Console.WriteLine("2. Ticket Price Calculator");
        Console.WriteLine("3. Triangle Type Identifier");
        Console.Write("Enter your choice (1-3): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                GradeCalculator.Run();
                break;
            case "2":
                TicketPriceCalculator.Run();  
                break;
            case "3":
                TriangleIdentifier.Run();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
