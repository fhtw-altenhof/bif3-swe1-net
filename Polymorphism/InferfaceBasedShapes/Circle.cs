using System;

namespace Bif3.Swe1.Oop.Polymorphism.InferfaceBasedShapes {
    class Circle : IShapeComposition {
        public int XOriginCoordinate { get; }
        public int YOriginCoordinate { get; }

        private int _radius;

        public Circle(int x, int y, int radius) {
            this.XOriginCoordinate = x;
            this.YOriginCoordinate = y;
            _radius = radius;
        }

        public double GetArea() {
            return 20;
        }

        public double GetPerimeter() {
            return 2 * _radius * Math.PI;
        }

        public void PrintShapeType() {
            Console.WriteLine("I'm a Circle");
        }

        public void ShowOrigin() {
            Console.WriteLine($"Origin at X: {XOriginCoordinate} Y: {YOriginCoordinate}");
        }
    }
}
