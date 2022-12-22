namespace SimpleSnake.Core.Engine.Contracts
{
    using System;
    using System.Threading;

    using SimpleSnake.Core.Enums;
    using SimpleSnake.Core.GameObjects;
    using SimpleSnake.GameObjects;

    public class Engine : IEngine
    {
        private const double DEFALT_SLEEPTIME = 100;

        private Point[] directionPoints;
        private Wall wall;
        private Direction direction;
        private readonly Snake snake;
        private double sleepTime;
        private double difficulty = 0.01;

        private Engine()
        {
            directionPoints = new Point[4];
            sleepTime = DEFALT_SLEEPTIME;
        }

        public Engine(Wall wall, Snake snake)
            :this()
        {
            this.wall = wall;
            this.snake = snake;
        }

        public void Run()
        {
            GetDirectionPoints();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    GetNextDirection();
                }

                bool canMove = snake.IsMoving(this.directionPoints[(int)this.direction]);

                if (!canMove)
                {
                    AskuserForRestart();
                }

                sleepTime -= difficulty;
                Thread.Sleep((int)sleepTime);
            }
        }

        private void AskuserForRestart()
        {
            int leftX = wall.LeftX + 1;
            int topY = 3;

            Console.SetCursorPosition(leftX, topY);
            Console.Write("Whould you like to continue? y/n");

            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else
            {
                StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(20, 10);
            Console.Write("Game Over!");
            Environment.Exit(0);
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            if (userInput.Key == ConsoleKey.LeftArrow || userInput.Key == ConsoleKey.A)
            {
                if (direction != Direction.Right)
                {
                    direction = Direction.Left;
                }
            }
            else if (userInput.Key == ConsoleKey.RightArrow || userInput.Key == ConsoleKey.D)
            {
                if (direction != Direction.Left)
                {
                    direction = Direction.Right;
                }
            }
            else if (userInput.Key == ConsoleKey.UpArrow || userInput.Key == ConsoleKey.W)
            {
                if (direction != Direction.Down)
                {
                    direction = Direction.Up;
                }
            }
            else if (userInput.Key == ConsoleKey.DownArrow || userInput.Key == ConsoleKey.S)
            {
                if (direction != Direction.Up)
                {
                    direction = Direction.Down;
                }
            }

            Console.CursorVisible = false;
        }

        private void GetDirectionPoints()
        {
            directionPoints[(int)Direction.Right] = new Point(1, 0);
            directionPoints[(int)Direction.Left] = new Point(-1, 0);
            directionPoints[(int)Direction.Up] = new Point(0, -1);
            directionPoints[(int)Direction.Down] = new Point(0, 1);
        }
    }
}
