using UnityEngine;

namespace Ex_6
{
    public class Geometry : MonoBehaviour
    {
        static void main()
        {
            Square square1 = new Square(5);
            Circle circle1 = new Circle(3);
            Rectangle rectangle1 = new Rectangle(4, 6);
            

            Debug.Log("Square 1 Area: " + square1.Area());
            Debug.Log("Square 1 Perimeter: " + square1.Perimeter());
            Debug.Log("Circle 1 Area: " + circle1.Area());
            Debug.Log("Circle 1 Perimeter: " + circle1.Perimeter());
            Debug.Log("Rectangle 1 Area: " + rectangle1.Area());
            Debug.Log("Rectangle 1 Perimeter: " + rectangle1.Perimeter());

            square1.Colored("Red");
            circle1.Colored("Blue");
            rectangle1.Colored("Green");

            square1.Positioned(2, 3);
            circle1.Positioned(5, 7);
            rectangle1.Positioned(1, 4);

            Square squareClone = (Square)square1.Clone();
            Circle circleClone = (Circle)circle1.Clone();
            Rectangle rectangleClone = (Rectangle)rectangle1.Clone();

            Debug.Log("Square Clone Area: " + squareClone.Area());
            Debug.Log("Circle Clone Area: " + circleClone.Area());
            Debug.Log("Rectangle Clone Area: " + rectangleClone.Area());
        }

        void Start()
        {
            main();
        }
    }
}