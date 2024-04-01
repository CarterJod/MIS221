// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double num1 = 0.0;
double num2 = 0.0;

Console.WriteLine("Enter the first number");

string userInput = Console.ReadLine();
num1 = double.Parse(userInput);

Console.WriteLine("Enter the second number");
num2 = double.Parse(Console.ReadLine());

Console.WriteLine("The remainder of " + num1 + " divided by " + num2 + " is " + (num1 % num2));

