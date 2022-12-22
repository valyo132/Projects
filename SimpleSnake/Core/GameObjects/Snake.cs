namespace SimpleSnake.Core.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using SimpleSnake.Core.GameObjects.FoodTypes;
    using SimpleSnake.GameObjects;
    using SimpleSnake.GameObjects.FoodTypes;

    public class Snake
    {
        private const char snakeSumbol = 'O';

        private Queue<Point> snakeParts;
        private IList<Food> food;
        private Wall wall;

        private int nextTopY;
        private int nextLeftX;
        private int foodIndex;

        private Snake()
        {
            this.snakeParts = new Queue<Point>();
            this.food = new List<Food>();
            foodIndex = RandowmFoodNumber;

            this.CreateSnake();
        }

        public Snake(Wall wall)
            : this()
        {
            this.wall = wall;

            this.GetFoods();
        }

        private int RandowmFoodNumber => new Random().Next(0, food.Count);

        private void CreateSnake()
        {
            for (int topY = 1; topY < 6; topY++)
            {
                this.snakeParts.Enqueue(new Point(2, topY));
            }
        }

        public bool IsMoving(Point direction)
        {
            Point snakeHead = snakeParts.Last();

            GetNextPoint(direction, snakeHead);

            bool isPointOfSnake = snakeParts.Any(x => x.LeftX == nextLeftX && x.TopY == nextTopY);

            if (isPointOfSnake)
                return false;

            Point newHead = new Point(nextLeftX, nextTopY);

            if (wall.IsPointOfWall(newHead))
                return false;

            this.snakeParts.Enqueue(newHead);
            newHead.Draw(snakeSumbol);

            if (food[foodIndex].IsFoodPoint(newHead))
            {
                Eat(direction, snakeHead);
            }

            Point tale = snakeParts.Dequeue();
            tale.Draw(' ');

            return true;
        }

        private void GetFoods()
        {
            food.Add(new FoodHash(this.wall));
            food.Add(new FoodAsterisk(this.wall));
            food.Add(new FoodDollar(this.wall));

            SpawnFood();
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;
        }

        private void Eat(Point direction, Point currSnakeHead)
        {
            int foodPoints = this.food[foodIndex].FoodPoints;

            for (int i = 0; i < foodPoints; i++)
            {
                snakeParts.Enqueue(new Point(nextLeftX, nextTopY));
                this.GetNextPoint(direction, currSnakeHead);
            }

            SpawnFood();
        }

        private void SpawnFood()
        {
            foodIndex = RandowmFoodNumber;
            food[foodIndex].SetRandomPosition(snakeParts);
        }
    }
}
