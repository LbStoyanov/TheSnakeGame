using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private const char snakeSymbol = '\u25CF';
        private  Queue<Point> snakeElements;

        public Snake()
        {
            
            this.CreateSnake();
        }

        private void CreateSnake()
        {
            this.snakeElements = new Queue<Point>();

            for (int i = 1; i <= 6; i++)
            {
                Point point = new Point(i, 1);
                snakeElements.Enqueue(point);
                point.Draw(snakeSymbol);
            }
        }
    }
}
