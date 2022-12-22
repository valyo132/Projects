namespace SimpleSnake.GameObjects.FoodTypes
{
    using System;

    public class FoodHash : Food
    {
        private const char FOOD_SYMBOL = '#';
        private const int POINTS = 5;
        private const ConsoleColor COLOR = ConsoleColor.Magenta;

        public FoodHash(Wall wall)
            : base(wall, FOOD_SYMBOL, POINTS, COLOR)
        { }
    }
}
