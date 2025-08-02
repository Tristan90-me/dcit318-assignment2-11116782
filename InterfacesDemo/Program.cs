using System;

namespace InterfacesDemo
{
    // Interface definition
    interface IMovable
    {
        void Move();
    }

    // Car class implementing IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving 🚗");
        }
    }

    // Bicycle class implementing IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving 🚲");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "🚙 IMovable Interface Demo";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=== Welcome to the IMovable Interface Demo ===\n");

            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("Choose a transport to move:");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Bicycle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                IMovable movable = null;

                switch (input)
                {
                    case "1":
                        movable = new Car();
                        break;
                    case "2":
                        movable = new Bicycle();
                        break;
                    case "0":
                        Console.WriteLine("Thank you for using the interface demo. Goodbye! 👋");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please try again.\n");
                        continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                movable.Move();
                Console.WriteLine();
            }
        }
    }
}
