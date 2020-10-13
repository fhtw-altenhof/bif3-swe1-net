using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using NUnit.Framework;

namespace Bif3.Swe1.UnitTest {
    [TestFixture]
    public class ShapeLibraryUnitTests {
        private const int expectedZeroCount = 0;
        private const int expectedOneCount = 1;

        [SetUp]
        public void Setup() {
        }

        [Test]
        public void TestLineLengthCalculation() {
            // allocate
            Line line = new Line(0, 1, 1, 1);

            // act 
            double actualLinePerimeter = line.GetPerimeter();
            double expectedLinePerimeter = 1;
            
            // assert
            Assert.AreEqual(expectedLinePerimeter, actualLinePerimeter);
        }

        [Test]
        public void TestCircleAreaCalculation() {
            // allocate
            Circle circle = new Circle(5, 5, 3);

            // act 
            double actualCircleArea = circle.GetArea();
            double expectedCircleArea = 28.274333882308139146;

            // assert
            Assert.AreEqual(expectedCircleArea, actualCircleArea);
        }

        [Test]
        public void TestCompoundShapeAdd() {
            // allocate
            CompoundShape compoundShape = new CompoundShape(7, 7);

            // act 
            compoundShape.Add(new Line(3, 4, 5, 6));

            // assert
            Assert.AreEqual(expectedOneCount, compoundShape.Count);
        }

        [Test]
        public void TestCompoundShapeClear() {
            // allocate
            CompoundShape compoundShape = new CompoundShape(7, 7);

            // act 
            compoundShape.Add(new Line(3, 4, 5, 6));
            compoundShape.Clear();

            // assert
            Assert.AreEqual(expectedZeroCount, compoundShape.Count);
        }

        [TearDown]
        public void TearDown() {
        }
    }
}