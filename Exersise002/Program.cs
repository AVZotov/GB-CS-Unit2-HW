int randomNumber = new Random().Next(10, 1000);

Console.WriteLine($"Initial number is: {randomNumber}");

if (randomNumber / 100 > 0)
{
    Console.WriteLine($"third digit in number is: {randomNumber % 10}");
}
else
{
    Console.WriteLine("Number contains less then 3 digits");
}