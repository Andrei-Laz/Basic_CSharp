using Unity.Mathematics.Geometry;
using UnityEngine;

namespace Ex_6
{
    public class Circle : Figure, IColourable, IPositionable, IClonable
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        
        }

        public override double Area()
        {
            return System.Math.PI * _radius * _radius;
        }

        public override double Perimeter()
        {
            return 2 * System.Math.PI * _radius;
        }

        public void Colored(string color)
        {
            Debug.Log($"The circle is colored {color}.");
        }

        public void Positioned(double x, double y)
        {
            Debug.Log($"The center of the circle is positioned at ({x}, {y}).");
        }

        public object Clone()
        {
            return new Circle(_radius);
        }
    }
}