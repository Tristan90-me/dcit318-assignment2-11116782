# 🚗 IMovable Interface Demo - DCIT 318 Assignment 2 (Task 3)

This C# console application demonstrates how to use **interfaces** in object-oriented programming. The program defines an `IMovable` interface and implements it in two different classes to simulate movement for different types of transport.

---

## ✅ Features

- 📘 Interface `IMovable` defines a method `Move()`.
- 🚙 `Car` class implements `Move()` and prints `"Car is moving 🚗"`.
- 🚲 `Bicycle` class implements `Move()` and prints `"Bicycle is moving 🚲"`.
- 🧠 Demonstrates **interface polymorphism**: calling the same method on different object types.
- 📋 Interactive menu for choosing transport mode.
- 🔁 Allows repeated usage with exit option.
- ❌ Handles invalid input gracefully.
- 🎨 Colored output for better user experience.

---

## 💻 How to Run

1. Clone the repository from GitHub or download the source files.
2. Open the project in **Visual Studio** or **Visual Studio Code** with the C# extension installed.
3. Build and run the application.

```bash
cd InterfacesDemo

dotnet run