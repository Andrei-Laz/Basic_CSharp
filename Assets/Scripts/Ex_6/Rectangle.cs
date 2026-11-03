using UnityEngine;

namespace Ex_6
{
    public class Rectangle : Figure, IColourable, IPositionable, IClonable
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public override double Area()
        {
            return _height * _width;
        }

        public override double Perimeter()
        {
            return 2 * (_height + _width);
        }

        public void Colored(string color)
        {
            Debug.Log($"The rectangle is colored {color}.");
        }

        public void Positioned(double x, double y)
        {
            Debug.Log($"The rectangle is positioned at ({x}, {y}).");
        }

        public object Clone()
        {
            return new Rectangle(_height, _width);
        }
    }
}
