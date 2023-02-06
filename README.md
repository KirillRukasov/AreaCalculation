# Area Calculation Library

## Problem Statement
The problem is to create a C# library that can calculate the area of a circle by radius and a triangle by three sides. The solution should also be evaluated for unit tests, ease of adding other shapes, and calculating the area of a shape without knowing its type in compile-time.

## Solution Overview
The solution to the problem consists of several classes, interfaces, and a factory method pattern to calculate the area of a circle by its radius and a triangle by three sides. The `AreaCalculation` class is the main class that provides the `GetArea` method to calculate the area. The `GetArea` method uses a `GetAreaFactory` object to determine the type of shape and delegate the calculation to the corresponding class. The factory method pattern is used to decouple the creation of the shape objects from their client. This makes it easier to add other shapes in the future.

The classes `Circle` and `Triangle` implement the `IFigure` interface and are responsible for calculating their respective areas. The classes `CircleParameters` and `TriangleParameters` implement the `IParameters` interface and represent the required parameters for each shape.

The solution is also equipped with unit tests and includes the ability to determine if a triangle is a right triangle.

## Running the Solution
To run the solution, create an instance of the 'AreaCalculation' class and call the 'GetArea' method with either 'CircleParameters' or 'TriangleParameters' as an argument.
'''
var service = new AreaCalculation();
var circleArea = service.GetArea(new CircleParameters(5));
'''

To check a triangle for rectangularity, use the 'IsRectangular' method of the 'TriangleParameters' class.
'''
var parameters = new TriangleParameters(sideA, sideB, sideC);
var triangle = new Triangle(parameters);

var result = triangle.IsRightTriangle();
''''

## Testing
The solution includes unit tests for the 'Circle' and 'Triangle' classes, which can be found in the 'AreaCalculation.Tests' assembly. The tests can be run using the built-in testing tools in Visual Studio or by using the [dotnet test](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test) command in the terminal.

## Conclusion
The solution provides a simple and flexible library for calculating the area of a circle and triangle. The solution is designed to be easily extendable by adding new shapes, and it can calculate the area of a shape without changing the client API.

# References
[C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)

[xUnit Testing Framework](https://xunit.net/)