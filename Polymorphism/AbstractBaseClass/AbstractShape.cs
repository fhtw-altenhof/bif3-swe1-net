using System;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass {
    abstract class AbstractShape {
        protected int x, y;

        public AbstractShape(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public abstract void PrintShapeType();

        public virtual void ShowOrigin() {
            Console.WriteLine(string.Format("Origin: {0}, {1}", x, y));
        }
    }
}
