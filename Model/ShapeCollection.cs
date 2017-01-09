using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ShapeCollection
    {
        public void AddShape(IShape shape)
        {
            shapes.Add(shape);
        }

        public void RemoveShape(IShape shape)
        {
            shapes.Remove(shape);
        }

        protected List<IShape> shapes = new List<IShape>();
    }
}
