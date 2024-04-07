using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shape Calculator Program!");

        string choice = "";
        while (choice != "3")
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Quit");
            Console.Write("Select a shape from the menu to calculate its area and perimeter: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Width: ");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Length: ");
                float length = float.Parse(Console.ReadLine());

                RectangleShape rectangleShape = new RectangleShape(0, 0, width, length);
                rectangleShape.CalculateArea();
                rectangleShape.CalculatePerimeter();
                rectangleShape.DisplayResults();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Base: ");
                float base1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Height: ");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Side1: ");
                float side1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Side2: ");
                float side2 = float.Parse(Console.ReadLine());

                TriangleShape triangleShape = new TriangleShape(0, 0, base1, height, side1, side2);
                triangleShape.CalculateArea();
                triangleShape.CalculatePerimeter();
                triangleShape.DisplayResults();
            }
        }
    }
}