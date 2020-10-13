using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;
using NUnit.Framework;

namespace Bif3.Swe1.UnitTest {
    [TestFixture]
    public class ShapeLibraryUnitTests {

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

        [TearDown]
        public void TearDown() {

        }
    }
}