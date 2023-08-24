using ObligatorioFernandezMorandi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RGBVectorTests
{
    [TestClass]
    public class RGBVectorTests
    {
        private RGBVector someColorVector;

        [TestInitialize]
        public void TestInit()
        {
            someColorVector = new RGBVector(0.3, 0.72, 0.1);
        }

        [TestMethod]
        public void CreateColorVectorSuccessTest()
        {
            RGBVector vector = new RGBVector(0.25, 0.33, 0);

            Assert.IsNotNull(vector);
            Assert.AreEqual(Math.Round(vector.X, 2), 0.25);
            Assert.AreEqual(Math.Round(vector.Y, 2), 0.33);
            Assert.AreEqual(Math.Round(vector.Z, 2), 0);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Color values are not valid")]
        public void GivenInvalidRedValueDoesntCreateVector()
        {
            RGBVector invalidVector = new RGBVector(2, 0.5, 0.5);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Color values are not valid")]
        public void GivenInvalidGreenValueDoesntCreateVector()
        {
            RGBVector invalidVector = new RGBVector(0.5, 2, 0.5);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Color values are not valid")]
        public void GivenInvalidBlueValueDoesntCreateVector()
        {
            RGBVector invalidVector = new RGBVector(0.5, 0.5, -2);
        }
        
        [TestMethod]
        public void ValidVectorReturnsCorrectRedColor()
        {
            Assert.AreEqual(77, Math.Round(someColorVector.Red(), 2));
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Red value is not valid")]
        public void InvalidColorVectorRed()
        {
            var invalidRedVector = new RGBVector(1, 0.2, 0.5);
            invalidRedVector.X = 2;
            var red = invalidRedVector.Red();
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectGreenColor()
        {
            Assert.AreEqual(184, Math.Round(someColorVector.Green(), 2));
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Green value is not valid")]
        public void InvalidColorVectorGreen()
        {
            var invalidGreenVector = new RGBVector(0.15, 1, 0.5);
            invalidGreenVector.Y = 2;
            var green = invalidGreenVector.Green();
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectBlueColor()
        {
            Assert.AreEqual(26, Math.Round(someColorVector.Blue(), 2));
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Blue value is not valid")]
        public void InvalidColorVectorBlue()
        {
            var invalidBlueVector = new RGBVector(0.15, 0.2, 1);
            invalidBlueVector.Z = 2;
            var blue = invalidBlueVector.Blue();
        }
        
    }
}
