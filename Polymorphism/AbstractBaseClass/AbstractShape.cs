using System;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass {
    abstract class AbstractShape {
        protected int _x, _y;

        public AbstractShape(int x, int y) {
            this._x = x;
            this._y = y;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public abstract void PrintShapeType();

        public virtual void ShowOrigin() {
            Console.WriteLine(string.Format("Origin: {0}, {1}", this._x, this._y));
        }
    }
}
