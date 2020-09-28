using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using System;
using System.Collections.Generic;

namespace Bif3.Swe1.Oop.ShapeStack {
    class ShapeStack {

        private List<IShapeComposition> _shapeList = new List<IShapeComposition>();
        private int _top = 0;
        private int _maxSize = 0;

        public ShapeStack(int maxSize) {
            _top = 0;
            _maxSize = maxSize;
        }

        public void Push(IShapeComposition shapeObj) {
            throw new NotImplementedException();
        }

        public IShapeComposition Pop() {
            throw new NotImplementedException();
        }

        public bool IsEmpty() {
            throw new NotImplementedException();
        }

        public void DescribeStack() {
            throw new NotImplementedException();
        }
    }
}
