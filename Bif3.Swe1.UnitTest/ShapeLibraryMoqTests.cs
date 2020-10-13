using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using Moq;
using NUnit.Framework;

namespace Bif3.Swe1.UnitTest {
    [TestFixture]
    public class ShapeLibraryMoqTests {

        private CompoundShape _compoundShape;

        [OneTimeSetUp]
        public void Setup() {
            _compoundShape = new CompoundShape(7, 7);
        }

        [Test]
        public void TestCircleShapeMock() {
            // allocate
            var mockShape = new Mock<IShapeComposition>();

            mockShape.Setup(shape => shape.GetArea()).Returns(5);
            mockShape.Setup(shape => shape.GetPerimeter()).Returns(3);

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
            var mockShape1 = new Mock<IShapeComposition>();
            var mockShape2 = new Mock<IShapeComposition>();

            mockShape1.Setup(shape => shape.GetArea()).Returns(5);
            mockShape2.Setup(shape => shape.GetArea()).Returns(7);

            // act
            _compoundShape.Add(mockShape1.Object);
            _compoundShape.Add(mockShape2.Object);

            double actualAreaSum = _compoundShape.GetArea();
            double expectedAreaSum = 12;

            // assert
            Assert.AreEqual(expectedAreaSum, actualAreaSum);
        }

        [TearDown]
        public void TearDown() {
            _compoundShape.Clear();
        }
    }
}
