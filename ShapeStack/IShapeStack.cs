using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;

namespace Bif3.Swe1.Oop.ShapeStack {
    interface IShapeStack {
        void Push(IShapeComposition shapeObj);
        IShapeComposition Pop();
        bool IsEmpty();
        void DescribeStack();
    }
}
