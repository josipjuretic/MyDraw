using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace Model
{
    static class ShapeFactory
    {
        public static IShape CreateShape(ShapeType shapeType, Point leftTop)
        {
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle(leftTop);
                case ShapeType.Ellipse:
                    return new Ellipse(leftTop);
                default:
                    throw new InvalidEnumArgumentException(nameof(shapeType), (int)shapeType, typeof(ShapeType));
            }
        }
    }
}
