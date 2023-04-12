int dayOfWeek = new Random().Next(1, 8);

if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine($"day number {dayOfWeek} is a vacation day");
}
else
{
    Console.WriteLine($"day number {dayOfWeek} is working day");
}