using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodAsterix : Food
    {
        public FoodAsterix(Wall wall) 
            : base(wall, '*', 1)
        {
        }
    }
}
