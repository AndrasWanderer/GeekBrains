Console.BufferHeight = Console.WindowHeight = 30;
Console.BufferWidth = Console.WindowWidth = 70;

Console.ForegroundColor = ConsoleColor.Green;

var random = new Random();

while (true)
{
    Thread.Sleep(100);

    for (var i = 0; i < 15; i++)
    {
        var column = random.Next(0, 70);
        var speed = random.Next(1, 5);

        for (var j = 0; j < 30; j++)
        {
            Console.SetCursorPosition(column, j);

            Console.Write((char)random.Next(0, 255));

            Thread.Sleep(speed);
        }
    }
}