using AreaLibrary;
using System.Runtime.Intrinsics.X86;


namespace AreaUnitTest
{
    [TestClass]
    public class AreaUnitTests
    {
        [TestMethod]
        public void CalculateArea_ReturnsArea_Heron()
        {
            // Arrange
            double a = 2;
            double b = 6;
            double c = 7;
            double expected = 5.562;

            Triangle triangle = new Triangle(a, b, c);
            
            // Act
            double actual = triangle.CalculateArea();
            
            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Calculated area does not match expected value");

            
        }

        [TestMethod]
        public void InvalidTriangle_Zero()
        {
            // Arrange
            double a = 3;
            double b = 0;
            double c = 7;

            Triangle triangle = new Triangle(a, b, c);
            
            // Act
            double actual = triangle.CalculateArea();
            
            //Assert
            Assert.AreEqual(0, actual, 0, "Area should be zero for a triangle with a zero side");

        }

        [TestMethod]
        public void CalculateArea_RightTriangle()
        {
            // Arrange
            double a = 13;
            double b = 5;
            double c = 12;
            double expected = 30;

            Triangle triangle = new Triangle(a, b, c);
            
            // Act
            double actual = triangle.CalculateArea();

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Calculated area does not match expected value");
        }

        [TestMethod]
        public void CalculateArea_SidesWithFloatingPoints()
        {
            // Arrange
            double a = 2.5;
            double b = 3.7;
            double c = 4.1;
            double expected = 4.558;

            Triangle triangle = new Triangle(a, b, c);

            // Act
            double actual = triangle.CalculateArea();
            
            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Calculated area does not match expected value");

        }

        [TestMethod]
        public void CalculateArea_NegariveSide()
        {
            // Arrange
            double a = 42;
            double b = -5;
            double c = 10;

            Triangle triangle = new Triangle(a, b, c);
            
            // Act
            double actual = triangle.CalculateArea();

            //Assert
            Assert.AreEqual(0, actual, 0, "Area should be zero for a triangle with a negative side");

        }

        [TestMethod]
        public void CalculateArea_InvalidTriangle()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 5;

            Triangle triangle = new Triangle(a, b,c);
            
            // Act
            double actual = triangle.CalculateArea();

            //Assert
            Assert.AreEqual(0, actual, 0, "Area should be zero for a invalid triangle");
        }


        [TestMethod]
        public void CalculateArea_ValidCircle()
        {
            // Arrange
            double radius = 5;
            double expected = 78.540;

            Circle circle = new Circle(radius);
            
            // Act
            double actual = circle.CalculateArea();

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Calculated area does not match expected value");

        }

        [TestMethod]
        public void CalculateArea_ZeroRadius() 
        {
            // Arrange
            double radius = 0;
            
            Circle circle = new Circle(radius);
            
            // Act
            double actual = circle.CalculateArea();
            
            //Assert
            Assert.AreEqual(0, actual, 0, "Area should be zero for a cirle with zero radius");
            
        }

        [TestMethod]
        public void CalculateArea_NegativeRadius()
        {
            // Arrange
            double radius = -56;
            
            Circle circle = new Circle(radius);
            
            // Act
            double actual = circle.CalculateArea();
            
            //Assert
            Assert.AreEqual(0, actual, 0, "Area should be zero for a cirlce with a negative side");

        }

        [TestMethod]
        public void CalculateArea_FloatingPointsRadius()
        {
            // Arrange
            double radius = 2.5;
            double expected = 19.635;

            Circle circle = new Circle(radius);
            
            // Act
            double actual = circle.CalculateArea();
            
            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Calculated area does not match expected value");
        } 


    }
}