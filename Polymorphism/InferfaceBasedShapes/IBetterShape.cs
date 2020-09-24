namespace Bif3.Swe1.Oop.Polymorphism.InferfaceBasedShapes {
    interface IBetterShape {
        int XOriginCoordinate { get; }
        int YOriginCoordinate { get; }
        void PrintShapeType();
        void ShowOrigin();
    }
}
