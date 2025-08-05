using System;

public class TriangleIdentifier
{
    public static void Run()
    {
        Console.WriteLine("\nTRIANGLE TYPE IDENTIFIER");

        Console.Write("Enter side 1: ");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side 2: ");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side 3: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        if (!IsValidTriangle(side1, side2, side3))
        {
            Console.WriteLine("The values do not form a valid triangle.");
            return;
        }

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Triangle Type: Equilateral");
        else if (side1 == side2 || side2 == side3 || side1 == side3)
            Console.WriteLine("Triangle Type: Isosceles");
        else
            Console.WriteLine("Triangle Type: Scalene");
    }

    static bool IsValidTriangle(int a, int b, int c)
    {
        // Triangle inequality rule
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
