using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using Moq;
using NUnit.Framework;

namespace Bif3.Swe1.UnitTest {
    [TestFixture]
    public class ShapeLibraryMoqTests {

        private const double mockValue1 = 5;
        private const double mockValue2 = 3;

        private CompoundShape _compoundShape;

        [OneTimeSetUp]
        public void Setup() {
            _compoundShape = new CompoundShape(7, 7);
        }

        [Test]
        public void TestCircleShapeMock() {
            // arrange
            var mockShape = new Mock<IShapeComposition>();

            mockShape.Setup(shape => shape.GetArea()).Returns(mockValue1);
            mockShape.Setup(shape => shape.GetPerimeter()).Returns(mockValue2);

            // act
            double tempArea = mockShape.Object.GetArea();
            double tempPerimeter = mockShape.Object.GetPerimeter();

            // assert
            mockShape.Verify(shape => shape.GetArea());
            mockShape.Verify(shape => shape.GetPerimeter());
        }

        [Test]
        public void TestCompoundShapeMock() {
            // allocate
            double expectedAreaSum = 8;

            var mockShape1 = new Mock<IShapeComposition>();
            var mockShape2 = new Mock<IShapeComposition>();

            mockShape1.Setup(shape => shape.GetArea()).Returns(mockValue1);
            mockShape2.Setup(shape => shape.GetArea()).Returns(mockValue2);

            // act
            _compoundShape.Add(mockShape1.Object);
            _compoundShape.Add(mockShape2.Object);

            double actualAreaSum = _compoundShape.GetArea();

            // assert
            Assert.AreEqual(expectedAreaSum, actualAreaSum);
        }

        [TearDown]
        public void TearDown() {
            _compoundShape.Clear();
        }
    }
}
