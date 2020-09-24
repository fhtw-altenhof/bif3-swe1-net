using System;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass {
    class DerivedLine : AbstractShape {

        private int _x2, _y2;

        public DerivedLine(int x1, int y1, int x2, int y2) : base(x1, y1) {
            this._x2 = x2;
            this._y2 = y2;
        }

        public override double GetArea() {
            return 2;
        }

        public override double GetPerimeter() {
            return 10;
        }

        public override void PrintShapeType() {
            Console.WriteLine("I'm a Line");
        }

        public override void ShowOrigin() {
            Console.WriteLine(
                string.Format("Origin: {0}, {1} End: {2}, {3}", _x, _y, _x2, _y2));
        }
    }
}
