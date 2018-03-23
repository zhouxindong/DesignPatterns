using System;
using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// ensure consistency of use single object and composite object
    /// </summary>
    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }

    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }

    public class CompositeShape : IShape
    {
        private readonly IList<IShape> _shapes = new List<IShape>();

        public void Add(IShape shape)
        {
            _shapes.Add(shape);
        }

        public void Draw()
        {
            foreach (var shape in _shapes)
            {
                shape.Draw();
            }
        }
    }
}