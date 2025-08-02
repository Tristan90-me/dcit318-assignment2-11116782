using System;

namespace InheritanceAndOverriding
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class: Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class: Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "🐾 Inheritance & Method Overriding Demo";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Welcome to the Animal Sound Simulator ===\n");

            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("Choose an animal:");
                Console.WriteLine("1. Generic Animal");
                Console.WriteLine("2. Dog");
                Console.WriteLine("3. Cat");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                Animal animal = null;

                switch (input)
                {
                    case "1":
                        animal = new Animal();
                        break;
                    case "2":
                        animal = new Dog();
                        break;
                    case "3":
                        animal = new Cat();
                        break;
                    case "0":
                        Console.WriteLine("Thank you for using the simulator. Goodbye! 👋");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Sound: ");
                animal.MakeSound();
                Console.WriteLine();
            }
        }
    }
}
