// See https://aka.ms/new-console-template for more information

using LearningInterfaces;
using LearningInterfaces.Models;
using LearningInterfaces.Services;

Console.WriteLine("Which Kind of shape you need? \n Press 1 for Triangle and 2 for Square :- \n");
var input = Console.ReadLine();

var shape = new BaseShape();

if (input == "1")
    {
        Console.WriteLine("You have Selected the Triangle shape.");
        shape = new Triangle();
    }
else if (input == "2")
    {
        Console.WriteLine("You have Selected the Square shape.");
        shape = new Square();
    }
else
    {
    Console.WriteLine("You have Selected a wrong option.");
}


Console.WriteLine("Enter the length :- ");
var length = Convert.ToDouble(Console.ReadLine());

ShapeFactory shapeFactory = new ShapeFactory();
ICalculateCircumference calculateCircumference = shapeFactory.GetCalculateCircumference(shape);


Console.WriteLine($"The Circumference of the shape is :- {calculateCircumference.CalculateCircumference(length)}");
Thread.Sleep(1000);


