using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public abstract class Food : Point
    {
        private readonly Wall wall;
        private readonly char foodSymbol;
        private readonly Random random;

        protected Food(Wall wall,char foodSymbol, int points) 
            : base(0, 0)
        {
            this.wall = wall;
            this.foodSymbol = foodSymbol;
            this.Points = points;
            this.random = new Random();
        }

        public int Points { get; private set; }

        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = this.random.Next(1, this.wall.LeftX - 1);
            this.TopY = this.random.Next(1, this.wall.TopY - 1);

            bool isPartOfSnake = snakeElements.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);

            while (isPartOfSnake)
            {
                this.LeftX = this.random.Next(1, this.wall.LeftX - 1);
                this.TopY = this.random.Next(1, this.wall.TopY - 1);

                isPartOfSnake = snakeElements.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);

            }

            Console.BackgroundColor = ConsoleColor.Green;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
