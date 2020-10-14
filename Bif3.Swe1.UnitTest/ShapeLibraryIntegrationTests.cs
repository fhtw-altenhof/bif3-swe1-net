using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using NUnit.Framework;

namespace Bif3.Swe1.UnitTest {
    [TestFixture]
    public class ShapeLibraryIntegrationTests {
        private const int expectedZeroCount = 0;
        private const int expectedOneCount = 1;
        private const int expectedTwoCount = 2;
        private const int expectedThreeCount = 3;

        private CompoundShape _compoundShape;
        private Line _line;
        private Circle _circle;

        [OneTimeSetUp]
        public void Setup() {
            _compoundShape = new CompoundShape(7, 7);
            _line = new Line(0, 1, 1, 1);
            _circle = new Circle(5, 5, 3);
        }

        [Test]
        public void TestCompoundShapeMath() {
            // arrange
            // manually calc sum of perimeters - line + circle + line
            double expectedPerimeterSum = 1 + 18.8495559215387594;
            // manually calc sum of areas - line + circle + line
            double expectedAreaSum = 0 + 28.274333882308139146;

            _compoundShape.Add(_line);
            _compoundShape.Add(_circle);

            // act
            double actualPerimeterSum = _compoundShape.GetPerimeter();
            double actualAreaSum = _compoundShape.GetArea();

            // assert
            Assert.AreEqual(expectedPerimeterSum, actualPerimeterSum);
            Assert.AreEqual(expectedAreaSum, actualAreaSum);
        }

        [Test]
        public void TestCompoundShapeContent() {
            // arrange
            Line line = new Line(3, 4, 5, 6);

            // act
            int actualZeroCount = _compoundShape.Count;         
            int actualOneCount = AddCompoundShapeAndGetCount(_line);
            int actualTwoCount = AddCompoundShapeAndGetCount(_circle);
            int actualThreeCount = AddCompoundShapeAndGetCount(line);

            _compoundShape.Clear();
            int actualClearCount = _compoundShape.Count;

            // assert (not an optimal solution for testing, but shows a way to test with multiple asserts)
            Assert.AreEqual(expectedZeroCount, actualZeroCount);
            Assert.AreEqual(expectedOneCount, actualOneCount);
            Assert.AreEqual(expectedTwoCount, actualTwoCount);
            Assert.AreEqual(expectedThreeCount, actualThreeCount);
            Assert.AreEqual(expectedZeroCount, actualClearCount);
        }

        private int AddCompoundShapeAndGetCount(IShapeComposition shape) {
            _compoundShape.Add(shape);
            return _compoundShape.Count;
        }

        [TearDown]
        public void TearDown() {
            _compoundShape.Clear();
        }
    }
}