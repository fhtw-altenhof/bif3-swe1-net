using System;
using System.Collections.Generic;

namespace Bif3.Swe1.Oop.Polymorphism.InferfaceBasedShapes {
    class CompoundShape : IShapeComposition {
        public int XOriginCoordinate { get; }
        public int YOriginCoordinate { get; }

        private List<IShapeComposition> shapeList = new List<IShapeComposition>();

        public CompoundShape(int x, int y) {
            this.XOriginCoordinate = x;
            this.YOriginCoordinate = y;
        }

        public void Add(IShapeComposition shape) {
            shapeList.Add(shape);
        }

        public double GetArea() {
            double tempArea = 0;
            foreach (IShapeComposition shape in shapeList) {
                tempArea += shape.GetArea();
            }
            Console.WriteLine($"Sum of all perimeters: {tempArea}");

            return tempArea;
        }

        public double GetPerimeter() {
            double tempPerimeter = 0;
            foreach (IShapeComposition shape in shapeList) {
                tempPerimeter += shape.GetPerimeter();
            }
            Console.WriteLine($"Sum of all perimeters: {tempPerimeter}");

            return tempPerimeter;
        }

        public void PrintShapeType() {
            Console.WriteLine("I'm a CompoundShape");
            foreach (IShape shape in shapeList) {
                shape.PrintShapeType();
            }
        }

        public void ShowOrigin() {
            Console.WriteLine($"Origin at X: {XOriginCoordinate} Y: {YOriginCoordinate}");
        }
    }
}
