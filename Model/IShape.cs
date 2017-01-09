using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IShape
    {
        int Left { get; set; }
        int Top { get; set; }
        int Right { get; set; }
        int Bottom { get; set; }
        //void Move(int deltaX, int deltaY);
        //void Resize(int deltaLeft, int deltaTop, int deltaRight, int deltaBottom);
    }
}
