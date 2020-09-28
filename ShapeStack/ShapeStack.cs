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
            if (IsEmpty()) {
                Console.WriteLine("STACK UNDERFLOW!");
                return null;
            }
            IShapeComposition tempShape = _shapeList[_top];
            _top--;
            return tempShape;
        }

        public bool IsEmpty() {
            throw new NotImplementedException();
        }

        public void DescribeStack() {
            foreach (IShapeComposition shape in _shapeList) {
                shape.PrintShapeType();
            }
        }
    }
}
