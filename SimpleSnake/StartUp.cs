namespace SimpleSnake
{
    using SimpleSnake.GameObjects;
    using System;
    using System.Collections.Generic;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {

            ConsoleWindow.CustomizeConsole();

            //Console.SetCursorPosition(30, 50);
            //Console.WriteLine("$");

            Wall wall = new Wall(130, 25);
            Food food = new FoodDollar(wall);
            food.SetRandomPosition(new Queue<Point>());

            Snake snake = new Snake();
            
        }
    }
}
