using System;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution {
    public class Line : Shape, IShapeComposition {

        private int _x2, _y2;

        public Line(int x1, int y1, int x2, int y2) : base(x1, y1) {
            this._x2 = x2;
            this._y2 = y2;
        }

        public double GetArea() {
            // lines do not have areas they cover
            return 0;
        }

        public double GetPerimeter() {
            // basically no perimeter for lines, but line length will be calculated
            return Math.Sqrt(Math.Pow((this._x2 - this._x), 2) + Math.Pow((this._y2 - this._y), 2));
        }

        public void PrintShapeType() {
            Console.WriteLine($"I'm a Line from {this._x},{this._y} to {this._x2},{this._y2}");
        }
    }
}
