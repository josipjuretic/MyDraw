using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Model
{
    abstract class Shape : IShape
    {
        public Shape(Point leftTop)
        {
            Left = Right = leftTop.X;
            Top = Bottom = leftTop.Y;
        }

        public int Bottom { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
        public int Top { get; set; }
    }
}
