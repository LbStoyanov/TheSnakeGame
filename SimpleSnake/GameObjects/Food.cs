using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public abstract class Food : Point
    {
        protected Food(int leftX, int topY) : base(leftX, topY)
        {
        }

        public int Points { get; set; }
    }
}
