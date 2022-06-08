namespace SimpleSnake
{
    using SimpleSnake.GameObjects;
    using System;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {

            

            ConsoleWindow.CustomizeConsole();

            Point point = new Point(12, 10);
            point.Draw('*');
            //Console.SetCursorPosition(100, 5);
            //Console.WriteLine("*");
        }
    }
}
