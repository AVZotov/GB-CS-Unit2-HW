int randomNumber = new Random().Next(100,1000);

Console.WriteLine("Program to show second number from 3 digits number");
Console.WriteLine($"Initial number: {randomNumber}");
int secondDigit = (randomNumber / 10) % 10;
Console.WriteLine($"Second digit: {secondDigit}");
