using System;

namespace Bif3.Swe1.Oop.Polymorphism.InferfaceBasedShapes {
    class BetterLine : IBetterShapeComposition {
        public int XOriginCoordinate { get; }
        public int YOriginCoordinate { get; }

        private int _xEndCoordinate, _yEndCoordinate;

        public BetterLine(int x1, int y1, int x2, int y2) {
            this.XOriginCoordinate = x1;
            this.YOriginCoordinate = y1;
            this._xEndCoordinate = x2;
            this._yEndCoordinate = y2;
        }

        public double GetArea() {
            return 15;
        }

        public double GetPerimeter() {
            // basically no perimeter for lines, but line length will do it
            return this.XOriginCoordinate + this._xEndCoordinate + this.YOriginCoordinate + this._yEndCoordinate;
        }

        public void PrintShapeType() {
            Console.WriteLine("I'm a Line");
        }

        public void ShowOrigin() {
            Console.WriteLine($"Origin at X: {this.XOriginCoordinate} Y: {this.YOriginCoordinate}");
        }
    }
}
