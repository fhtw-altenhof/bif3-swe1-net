using Bif3.Swe1.Oop.Classes;
using Bif3.Swe1.Oop.Inheritance;
using Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass;
using Bif3.Swe1.Oop.Polymorphism.InferfaceBasedShapes;
using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using Bif3.Swe1.Oop.ShapeStackGit;
using System;

namespace Bif3.Swe1.Oop {
    class Program {
        static void Main(string[] args) {

            // naming conventions
            // https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions?redirectedfrom=MSDN
            // https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md

            Console.WriteLine("Hello World!");

            // different types of string concatenation & interpolation
            string someStringValue = "some value";
            string anotherStringValue = "another value";
            string differentStringValue = "different value";

            string doNotConcatStringLikeThis = "Use this to format " + someStringValue + " with " + anotherStringValue + " and " + differentStringValue;
            string concatString = string.Concat(someStringValue, anotherStringValue, differentStringValue);
            string formatString = string.Format("Use this to format {0} with {1} and {2}", someStringValue, anotherStringValue, differentStringValue);
            string interpolateString = $"Use this to format {someStringValue} with {anotherStringValue} and {differentStringValue}";

            Console.WriteLine("-----");

            // class members
            Console.WriteLine(ClassWithMembers.StaticString);
            ClassWithMembers classWithMembers = new ClassWithMembers();
            classWithMembers.ChangeSomeValues(10);
            classWithMembers.WriteSomething();

            Console.WriteLine("-----");

            // Inheritance & Basic Polymorphism
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            bc.Method1();
            bc.Method2();

            dc.Method1();
            dc.Method2();

            // runtime polymorphism
            // calls method1 of derived class because of virtual/override
            bcdc.Method1();
            // calls method2 of base class, because of new keyword (method hiding)
            bcdc.Method2();
            // calls overloaded method2 of derived class because of casting
            ((DerivedClass)bcdc).Method2("sdf");

            Console.WriteLine("-----");

            // Polymorphism with abstract base class
            AbstractShape abstractLine = new DerivedLine(0, 1, 1, 1);
            abstractLine.ShowOrigin();
            double abstractLinePerimeter = abstractLine.GetPerimeter();

            AbstractShape abstractCircle = new DerivedCircle(5, 5, 3);
            abstractCircle.ShowOrigin();
            double abstractCircleArea = abstractCircle.GetArea();

            DerivedCompoundShape derivedCompound = new DerivedCompoundShape(7, 7);
            derivedCompound.Add(abstractLine);
            derivedCompound.Add(abstractCircle);
            derivedCompound.Add(new DerivedLine(3, 4, 5, 6));
            derivedCompound.ShowOrigin();
            derivedCompound.PrintShapeType();

            // casting works in IDE, but will throw an error at runtime if "line" is smth else than a Line obje
            //AbstractShape shape = new DerivedCircle(0, 0, 1);
            //DerivedLine line3 = (DerivedLine)shape;

            Console.WriteLine("-----");

            // Polymorphism with interfaces
            IBetterShapeComposition betterLine = new BetterLine(0, 1, 1, 1);
            betterLine.ShowOrigin();
            double betterLinePerimeter = betterLine.GetPerimeter();

            IBetterShapeComposition betterCircle = new BetterCircle(5, 5, 3);
            double betterCircleArea = betterCircle.GetArea();
            betterCircle.ShowOrigin();

            BetterCompoundShape betterCompound = new BetterCompoundShape(7, 7);
            betterCompound.Add(betterLine);
            betterCompound.Add(betterCircle);
            betterCompound.Add(new BetterLine(3, 4, 5, 6));
            betterCompound.ShowOrigin();
            betterCompound.PrintShapeType();

            Console.WriteLine("-----");

            // Very good solution for this usecase - Polymorphism with interfaces and a base class
            Line line = new Line(0, 1, 1, 1);
            line.ShowOrigin();
            double linePerimeter = line.GetPerimeter();

            Circle circle = new Circle(5, 5, 3);
            double circleArea = betterCircle.GetArea();
            betterCircle.ShowOrigin();

            CompoundShape compoundShape = new CompoundShape(7, 7);
            compoundShape.Add(line);
            compoundShape.Add(circle);
            compoundShape.Add(new Line(3, 4, 5, 6));
            compoundShape.ShowOrigin();
            compoundShape.PrintShapeType();

            Console.WriteLine("-----");

            IShapeStack shapeStack = new ShapeStack(5);
            shapeStack.Push(line);
            Console.WriteLine($"Is empty? {shapeStack.IsEmpty()}");

            if (!shapeStack.IsEmpty()) {
                shapeStack.DescribeStack();
            }

            Console.WriteLine("-----");

            IShapeComposition poppedShape = shapeStack.Pop();
            Console.WriteLine("Following shape was popped from stack:");
            poppedShape.PrintShapeType();
            Console.WriteLine($"Is stack empty? {shapeStack.IsEmpty()}");

            Console.WriteLine("-----");
        }
    }
}
