using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shape Calculator Program!");

        string choice = "";
        while (choice != "8")
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Regular Hexagon");
            Console.WriteLine("4. Trapezoid");
            Console.WriteLine("5. Circle");
            Console.WriteLine("6. Rhombus");
            Console.WriteLine("7. Square");
            Console.WriteLine("8. Quit");
            Console.Write("Select a shape from the menu by typing the corresponding number to calculate its area and perimeter: ");
            choice = Console.ReadLine();
            Console.WriteLine("Enter the indicated values:");

            if (choice == "1")
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Length: ");
                double length = double.Parse(Console.ReadLine());

                RectangleShape rectangleShape = new RectangleShape(width, length);
                rectangleShape.CalculateArea();
                rectangleShape.CalculatePerimeter();
                Console.WriteLine("");
                rectangleShape.DisplayShapeInformation();
                rectangleShape.DisplayResults();
            }
            else if (choice == "2")
            {
                Console.Write("Base: ");
                double base1 = double.Parse(Console.ReadLine());
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Side 1: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Side 2: ");
                double side2 = double.Parse(Console.ReadLine());

                TriangleShape triangleShape = new TriangleShape(base1, height, side1, side2);
                triangleShape.CalculateArea();
                triangleShape.CalculatePerimeter();
                Console.WriteLine("");
                triangleShape.DisplayShapeInformation();
                triangleShape.DisplayResults();
            }
            else if (choice == "3")
            {
                Console.Write("Apothem: ");
                double apothem = double.Parse(Console.ReadLine());
                Console.Write("Side: ");
                double side = double.Parse(Console.ReadLine());

                HexagonShape hexagonShape = new HexagonShape(side, apothem);
                hexagonShape.CalculatePerimeter();
                hexagonShape.CalculateArea();
                Console.WriteLine("");
                hexagonShape.DisplayShapeInformation();
                hexagonShape.DisplayResults();
            }
            else if (choice == "4")
            {
                Console.Write("Base 1: ");
                double base1 = double.Parse(Console.ReadLine());
                Console.Write("Base 2: ");
                double base2 = double.Parse(Console.ReadLine());
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Side 1: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Side 2: ");
                double side2 = double.Parse(Console.ReadLine());

                TrapezoidShape trapezoidShape = new TrapezoidShape(base1, base2, height, side1, side2);
                trapezoidShape.CalculatePerimeter();
                trapezoidShape.CalculateArea();
                Console.WriteLine("");
                trapezoidShape.DisplayShapeInformation();
                trapezoidShape.DisplayResults();
            }
            else if (choice == "5")
            {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine());

                CircleShape circleShape = new CircleShape(radius);
                circleShape.CalculatePerimeter();
                circleShape.CalculateArea();
                Console.WriteLine("");
                circleShape.DisplayShapeInformation();
                circleShape.DisplayResults();
            }
            else if (choice == "6")
            {
                Console.Write("Diagonal 1: ");
                double diagonal1 = double.Parse(Console.ReadLine());
                Console.Write("Diagonal 2: ");
                double diagonal2 = double.Parse(Console.ReadLine());
                Console.Write("Side: ");
                double side = double.Parse(Console.ReadLine());

                RhombusShape rhombusShape = new RhombusShape(diagonal1, diagonal2, side);
                rhombusShape.CalculatePerimeter();
                rhombusShape.CalculateArea();
                Console.WriteLine("");
                rhombusShape.DisplayShapeInformation();
                rhombusShape.DisplayResults();
            }
            else if (choice == "7")
            {
                Console.Write("Side: ");
                double side = double.Parse(Console.ReadLine());

                SquareShape squareShape = new SquareShape(side);
                squareShape.CalculatePerimeter();
                squareShape.CalculateArea();
                Console.WriteLine("");
                squareShape.DisplayShapeInformation();
                squareShape.DisplayResults();
            }
            else
            {
                Console.WriteLine("Invalid choice. Enter a valid number from the menu.");
            }
        }
    }
}