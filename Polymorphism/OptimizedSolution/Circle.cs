using System;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution {
    public class Circle : Shape, IShapeComposition {

        private int _radius;

        public Circle(int x, int y, int radius) : base(x, y) {
            _radius = radius;
        }

        public double GetArea() {
            return Math.Pow(this._radius, 2) * Math.PI;
        }

        public double GetPerimeter() {
            return 2 * _radius * Math.PI;
        }

        public void PrintShapeType() {
            Console.WriteLine("I'm a Circle");
        }
    }
}
