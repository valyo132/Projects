namespace SimpleSnake
{
    using System;

    using Core.Engine.Contracts;
    using Core.GameObjects;
    using GameObjects;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ConsoleWindow.CustomizeConsole();

            Wall wall = new Wall(60, 20);
            Snake snake = new Snake(wall);

            IEngine engine = new Engine(wall, snake);
            engine.Run();
        }
    }
}
