using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using System;
using System.Collections.Generic;

namespace Bif3.Swe1.Oop.ShapeStackGit {
    class ShapeStack : IShapeStack {

        private List<IShapeComposition> _shapeList = new List<IShapeComposition>();
        private int _top = 0;
        private int _maxSize = 0;

        public ShapeStack(int maxSize) {
            _top = 0;
            _maxSize = maxSize;
        }

        public void Push(IShapeComposition shapeObj) {
            if (_top >= _maxSize) {
                Console.WriteLine("STACK OVERFLOW!");
                return;
            }
            _top++;
            _shapeList.Add(shapeObj);
        }

        public IShapeComposition Pop() {
            throw new NotImplementedException();
        }

        public bool IsEmpty() {
            return _shapeList.Count == 0;
        }

        public void DescribeStack() {
            throw new NotImplementedException();
        }
    }
}
