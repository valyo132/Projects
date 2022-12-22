namespace SimpleSnake.Core.GameObjects.FoodTypes
{
    using System;

    using SimpleSnake.GameObjects;

    public class FoodDollar : Food
    {
        private const char FOOD_SYMBOL = '$';
        private const int POINTS = 2;
        private const ConsoleColor COLOR = ConsoleColor.Green;

        public FoodDollar(Wall wall)
            : base(wall, FOOD_SYMBOL, POINTS, COLOR)
        { }
    }
}
