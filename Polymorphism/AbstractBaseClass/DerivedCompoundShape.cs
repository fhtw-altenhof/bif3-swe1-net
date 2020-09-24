using System;
using System.Collections.Generic;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass {
    class DerivedCompoundShape : AbstractShape {
        private List<AbstractShape> shapeList = new List<AbstractShape>();

        public DerivedCompoundShape(int x, int y) : base(x, y) { }

        public void Add(AbstractShape shape) {
            shapeList.Add(shape);
        }

        public void PrintAllShapes() {
            PrintShapeType();
            foreach (AbstractShape shape in shapeList) {
                shape.PrintShapeType();
            }
        }

        public override void PrintShapeType() {
            Console.WriteLine("I'm a CompoundShape");
        }
    }
}
