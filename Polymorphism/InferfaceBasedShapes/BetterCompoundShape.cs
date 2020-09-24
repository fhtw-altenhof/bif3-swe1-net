using System;
using System.Collections.Generic;

namespace Bif3.Swe1.Oop.Polymorphism.InferfaceBasedShapes {
    class BetterCompoundShape : IBetterShapeComposition {
        public int XOriginCoordinate { get; }
        public int YOriginCoordinate { get; }

        private List<IBetterShapeComposition> _shapeList = new List<IBetterShapeComposition>();

        public BetterCompoundShape(int x, int y) {
            this.XOriginCoordinate = x;
            this.YOriginCoordinate = y;
        }

        public void Add(IBetterShapeComposition shape) {
            _shapeList.Add(shape);
        }

        public double GetArea() {
            double tempArea = 0;
            foreach (IBetterShapeComposition shape in _shapeList) {
                tempArea += shape.GetArea();
            }
            Console.WriteLine($"Sum of all perimeters: {tempArea}");

            return tempArea;
        }

        public double GetPerimeter() {
            double tempPerimeter = 0;
            foreach (IBetterShapeComposition shape in _shapeList) {
                tempPerimeter += shape.GetPerimeter();
            }
            Console.WriteLine($"Sum of all perimeters: {tempPerimeter}");

            return tempPerimeter;
        }

        public void PrintShapeType() {
            Console.WriteLine("I'm a CompoundShape");
            foreach (IBetterShape shape in _shapeList) {
                shape.PrintShapeType();
            }
        }

        public void ShowOrigin() {
            Console.WriteLine($"Origin at X: {XOriginCoordinate} Y: {YOriginCoordinate}");
        }
    }
}
