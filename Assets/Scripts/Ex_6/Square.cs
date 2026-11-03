using UnityEngine;

namespace Ex_6
{
    public class Square : Figure, IColourable, IPositionable, IClonable
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }

        public override double Area()
        {
            return _side * _side;
        }

        public override double Perimeter()
        {
            return 4 * _side;
        }

        public void Colored(string color)
        {
            Debug.Log($"The square is colored {color}.");
        }

        public void Positioned(double x, double y)
        {
            Debug.Log($"The square is positioned at ({x}, {y}).");
        }

        public object Clone()
        {
            return new Square(_side);
        }
    }
}