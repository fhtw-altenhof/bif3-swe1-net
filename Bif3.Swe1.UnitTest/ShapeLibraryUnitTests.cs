using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using NUnit.Framework;

namespace Bif3.Swe1.UnitTest {
    [TestFixture]
    public class ShapeLibraryUnitTests {
        private const int expectedZeroCount = 0;
        private const int expectedOneCount = 1;

        [SetUp]
        public void Setup() { }

        [Test]
        public void TestLineLengthCalculation() {
            // arrange
            Line line = new Line(0, 1, 1, 1);
            double expectedLinePerimeter = 1;

            // act 
            double actualLinePerimeter = line.GetPerimeter();
            
            // assert
            Assert.AreEqual(expectedLinePerimeter, actualLinePerimeter);
        }

        [Test]
        public void TestCircleAreaCalculation() {
            // arrange
            Circle circle = new Circle(5, 5, 3);
            double expectedCircleArea = 28.274333882308139146;

            // act 
            double actualCircleArea = circle.GetArea();

            // assert
            Assert.AreEqual(expectedCircleArea, actualCircleArea);
        }

        [Test]
        public void TestCompoundShapeAdd() {
            // arrange
            CompoundShape compoundShape = new CompoundShape(7, 7);

            // act 
            compoundShape.Add(new Line(3, 4, 5, 6));

            // assert
            Assert.AreEqual(expectedOneCount, compoundShape.Count);
        }

        [Test]
        public void TestCompoundShapeClear() {
            // arrange
            CompoundShape compoundShape = new CompoundShape(7, 7);

            // act 
            compoundShape.Add(new Line(3, 4, 5, 6));
            compoundShape.Clear();

            // assert
            Assert.AreEqual(expectedZeroCount, compoundShape.Count);
        }

        [TearDown]
        public void TearDown() { }
    }
}