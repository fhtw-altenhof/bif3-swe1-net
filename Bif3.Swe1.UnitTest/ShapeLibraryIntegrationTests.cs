using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using NUnit.Framework;

namespace Bif3.Swe1.UnitTest {
    public class ShapeLibraryIntegrationTests {
        private const int expectedZeroCount = 0;
        private const int expectedOneCount = 1;
        private const int expectedTwoCount = 2;
        private const int expectedThreeCount = 3;

        private CompoundShape _compoundShape;

        [SetUp]
        public void Setup() {
            _compoundShape = new CompoundShape(7, 7);
        }

        [Test]
        public void TestCompoundShapeMath() {
            Line line = new Line(0, 1, 1, 1);
            Circle circle = new Circle(5, 5, 3);
            _compoundShape.Add(line);
            _compoundShape.Add(circle);
            _compoundShape.Add(new Line(3, 4, 5, 6));

            // act
            double actualPerimeterSum = _compoundShape.GetPerimeter();
            // manually calc sum of perimeters - line + circle + line
            double expectedPerimeterSum = 1 + 18.8495559215387594 + 2.828427124746190097;

            double actualAreaSum = _compoundShape.GetArea();
            // manually calc sum of areas - line + circle + line
            double expectedAreaSum = 0 + 28.274333882308139146 + 0;

            // assert
            Assert.AreEqual(expectedPerimeterSum, actualPerimeterSum);
            Assert.AreEqual(expectedAreaSum, actualAreaSum);
        }

        public void TestCompoundShapeContent() {
            Line line = new Line(0, 1, 1, 1);
            Circle circle = new Circle(5, 5, 3);

            // act
            double actualZeroCount = _compoundShape.Count;

            _compoundShape.Add(line);
            double actualOneCount = _compoundShape.Count;

            _compoundShape.Add(circle);
            double actualTwoCount = _compoundShape.Count;

            _compoundShape.Add(new Line(3, 4, 5, 6));
            double actualThreeCount = _compoundShape.Count;

            _compoundShape.Clear();
            double actualClearCount = _compoundShape.Count;

            // assert (not an optimal solution for testing, but shows a way to test with multiple asserts)
            Assert.AreEqual(expectedZeroCount, actualZeroCount);
            Assert.AreEqual(expectedOneCount, actualOneCount);
            Assert.AreEqual(expectedTwoCount, actualTwoCount);
            Assert.AreEqual(expectedThreeCount, actualThreeCount);
            Assert.AreEqual(expectedZeroCount, actualClearCount);
        }

        [TearDown]
        public void TearDown() {
            _compoundShape.Clear();
        }
    }
}