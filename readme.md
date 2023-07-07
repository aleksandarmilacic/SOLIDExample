# SOLID Principles - Shape Area Calculator

This is a simple console application that demonstrates the application of the SOLID principles in a shape area calculator.

## Overview

The shape area calculator calculates and displays the areas of different shapes, including circles, rectangles, and squares. It adheres to the following SOLID principles:

- **Single Responsibility Principle (SRP):** Each class has a single responsibility. The `Circle`, `Rectangle`, and `Square` classes represent specific shapes and calculate their respective areas. The `AreaCalculator` class is responsible for calculating and displaying areas.

- **Open-Closed Principle (OCP):** The application is open for extension because new shapes can be easily added by implementing the `IShape` interface. The `AreaCalculator` class does not need to be modified to support new shapes.

- **Liskov Substitution Principle (LSP):** Objects of the `Circle`, `Rectangle`, and `Square` classes can be used interchangeably with objects of the `IShape` interface without breaking the application.

- **Interface Segregation Principle (ISP):** The `IShape` interface defines a single method `Area()` that all shapes implement. Clients only depend on this minimal interface and are not forced to depend on additional methods they don't use.

- **Dependency Inversion Principle (DIP):** The `AreaCalculator` class depends on the abstraction (`IShape` interface) rather than concrete implementations (`Circle`, `Rectangle`, `Square`). This allows for easy substitution of different shapes without affecting the `AreaCalculator` class.

## Usage

To use the shape area calculator, follow these steps:

1. Build the project to generate the executable file.

2. Run the executable from the command line or terminal.

3. The program will display the areas of different shapes (circle, rectangle, square) based on predefined values.

## Requirements

- .NET Framework (version X.X or higher)

## License

This project is licensed under the [MIT License](LICENSE).

