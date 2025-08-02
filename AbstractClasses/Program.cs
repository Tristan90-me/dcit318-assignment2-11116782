using System;

namespace AbstractClasses
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Circle class
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Rectangle class
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "📐 Shape Area Calculator (Abstract Classes)";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Welcome to the Shape Area Calculator ===\n");

            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("Choose a shape to calculate its area:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                Shape shape = null;

                switch (choice)
                {
                    case "1":
                        double radius = GetPositiveNumber("Enter the radius of the circle: ");
                        shape = new Circle(radius);
                        break;

                    case "2":
                        double width = GetPositiveNumber("Enter the width of the rectangle: ");
                        double height = GetPositiveNumber("Enter the height of the rectangle: ");
                        shape = new Rectangle(width, height);
                        break;

                    case "0":
                        Console.WriteLine("Thank you for using the calculator. Goodbye! 👋");
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please select a valid option.\n");
                        continue;
                }

                double area = shape.GetArea();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nThe area of the selected shape is: {area:F2}\n");
            }
        }

        static double GetPositiveNumber(string prompt)
        {
            double number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out number) && number > 0)
                    return number;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a positive number.\n");
                Console.ResetColor();
            }
        }
    }
}
