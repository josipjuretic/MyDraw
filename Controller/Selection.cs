using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class Selection : Model.ShapeCollection
    {
        System.Drawing.Rectangle GetBoundingRectangle()
        {
            int top = shapes.Min(s => s.Top);
            int left = shapes.Min(s => s.Left);
            int bottom = shapes.Max(s => s.Bottom);
            int right = shapes.Max(s => s.Right);
            return new System.Drawing.Rectangle(left, top, right - left, bottom - top);
        }
    }
}
