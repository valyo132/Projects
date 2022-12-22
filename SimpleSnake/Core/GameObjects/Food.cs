namespace SimpleSnake.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Food : Point
    {
        private ConsoleColor color;
        private Random rnd;
        private Wall wall;
        private char foodSymbol;

        public Food(Wall wall, char foodSymbol, int points, ConsoleColor color) 
            : base(wall.LeftX, wall.TopY)
        { 
            this.wall = wall;
            this.foodSymbol = foodSymbol;
            this.color = color;
            this.rnd = new Random();
            this.FoodPoints = points;
        }

        public int FoodPoints { get; private set; }

        public void SetRandomPosition(Queue<Point> snakeParts)
        {
            this.LeftX = rnd.Next(2, wall.LeftX - 2);
            this.TopY = rnd.Next(2, wall.TopY - 2);

            bool isFoodOnASnakeElement = snakeParts.Any(x => x.TopY == this.TopY && LeftX == this.LeftX);

            while (isFoodOnASnakeElement)
            {
                this.LeftX = rnd.Next(2, wall.LeftX - 2);
                this.TopY = rnd.Next(2, wall.TopY - 2);

                isFoodOnASnakeElement = snakeParts.Any(x => x.TopY == this.TopY && LeftX == this.LeftX);
            }

            Console.BackgroundColor = this.color;
            Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }

        public bool IsFoodPoint(Point snake)
            => snake.LeftX == this.LeftX && snake.TopY == this.TopY;
    }
}
