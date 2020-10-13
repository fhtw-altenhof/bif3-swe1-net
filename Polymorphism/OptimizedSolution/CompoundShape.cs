using System;
using System.Collections.Generic;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution {
    public class CompoundShape : Shape, IShapeComposition {

        private List<IShapeComposition> _shapeList = new List<IShapeComposition>();

        public CompoundShape(int x, int y) : base(x, y) {}

        public int Count => _shapeList.Count;

        public void Add(IShapeComposition shape) {
            _shapeList.Add(shape);
        }

        public double GetArea() {
            double tempArea = 0;
            foreach (IShapeComposition shape in _shapeList) {
                tempArea += shape.GetArea();
            }
            Console.WriteLine($"Sum of all perimeters: {tempArea}");

            return tempArea;
        }

        public double GetPerimeter() {
            double tempPerimeter = 0;
            foreach (IShapeComposition shape in _shapeList) {
                tempPerimeter += shape.GetPerimeter();
            }
            Console.WriteLine($"Sum of all perimeters: {tempPerimeter}");

            return tempPerimeter;
        }

        public void PrintShapeType() {
            Console.WriteLine("I'm a CompoundShape");
            foreach (IShapeComposition shape in _shapeList) {
                shape.PrintShapeType();
            }
        }

        public void Clear() {
            _shapeList.Clear();
        }
    }
}
