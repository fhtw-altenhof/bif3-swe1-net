using System;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass {
    class DerivedCircle : AbstractShape {

        private int _radius;

        public DerivedCircle(int x, int y, int radius) : base(x, y) {
            _radius = radius;
        }

        public double GetArea() {
            return _radius * 14;
        }

        public override void PrintShapeType() {
            Console.WriteLine("I'm a Circle");
        }
    }
}
