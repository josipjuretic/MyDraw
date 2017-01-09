using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Drawing : ShapeCollection
    {
        public IEnumerable<IShape> Shapes
        {
            get { return shapes; }
        }
    }
}
