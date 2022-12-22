namespace SimpleSnake.GameObjects.FoodTypes
{
    using System;

    public class FoodAsterisk : Food
    {
        private const char FOOD_SYMBOL = '*';
        private const int POINTS = 1;
        private const ConsoleColor COLOR = ConsoleColor.Red;

        public FoodAsterisk(Wall wall)
            : base(wall, FOOD_SYMBOL, POINTS, COLOR)
        { }
    }
}
