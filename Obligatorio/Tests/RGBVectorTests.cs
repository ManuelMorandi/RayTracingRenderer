using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class RGBVectorTests
    {
        private RGBVector someColorVector;

        private const int NumberOfDecimals = 2;

        [TestInitialize]
        public void TestInit()
        {
            someColorVector = new RGBVector(0.3, 0.72, 0.1);
        }

        [TestMethod]
        public void CreateColorVectorSuccessTest()
        {
            var expectedX = 0.25;
            var expectedY = 0.33;
            var expectedZ = 0;

            RGBVector vector = new RGBVector(expectedX, expectedY, expectedZ);

            Assert.IsNotNull(vector);
            Assert.AreEqual(Math.Round(vector.X, NumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(vector.Y, NumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(vector.Z, NumberOfDecimals), expectedZ);
        }

        [TestMethod]
        public void GivenAllMinColorValuesVectorGetsCreated()
        {
            var MinValue = 0;

            RGBVector validVector = new RGBVector(MinValue, MinValue, MinValue);

            Assert.IsNotNull(validVector);
            Assert.AreEqual(validVector.X, MinValue);
            Assert.AreEqual(validVector.Y, MinValue);
            Assert.AreEqual(validVector.Z, MinValue);
        }

        public void GivenAllMaxColorValuesVectorGetsCreated()
        {
            var MaxValue = 1;

            RGBVector validVector = new RGBVector(MaxValue, MaxValue, MaxValue);

            Assert.IsNotNull(validVector);
            Assert.AreEqual(validVector.X, MaxValue);
            Assert.AreEqual(validVector.Y, MaxValue);
            Assert.AreEqual(validVector.Z, MaxValue);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Los valores deben estar entre 0 y 1")]
        public void GivenTooLowRedValueDoesntCreateVector()
        {
            RGBVector invalidVector = new RGBVector(-1, 0.5, 0.5);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Los valores deben estar entre 0 y 1")]
        public void GivenTooHighRedValueDoesntCreateVector()
        {
            RGBVector invalidVector = new RGBVector(2, 0.5, 0.5);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Los valores deben estar entre 0 y 255")]
        public void GivenTooLowGreenValueDoesntCreateVector()
        {
            RGBVector invalidVector = new RGBVector(0.5, -1, 0.5);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Los valores deben estar entre 0 y 255")]
        public void GivenTooHighGreenValueDoesntCreateVector()
        {
            RGBVector invalidVector = new RGBVector(0.5, 2, 0.5);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Los valores deben estar entre 0 y 255")]
        public void GivenTooLowBlueValueDoesntCreateVector()
        {
            RGBVector invalidVector = new RGBVector(0.5, 0.5, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Los valores deben estar entre 0 y 255")]
        public void GivenTooHighBlueValueDoesntCreateVector()
        {
            RGBVector invalidVector = new RGBVector(0.5, 0.5, 2);
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectRedColor()
        {
            var expectedRedvalue = 77;
            Assert.AreEqual(Math.Round(someColorVector.Red(), NumberOfDecimals), expectedRedvalue);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El valor del color rojo debe estar entre 0 y 255")]
        public void ThrowsExceptionWhenAskedForTooLowRed()
        {
            var invalidRedVector = new RGBVector(1, 0.2, 0.5);
            invalidRedVector.X = -1;
            var red = invalidRedVector.Red();
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El valor del color rojo debe estar entre 0 y 255")]
        public void ThrowsExceptionWhenAskedForTooHighRed()
        {
            var invalidRedVector = new RGBVector(1, 0.2, 0.5);
            invalidRedVector.X = 2;
            var red = invalidRedVector.Red();
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectGreenColor()
        {
            var expectedGreenValue = 184;
            Assert.AreEqual(Math.Round(someColorVector.Green(), NumberOfDecimals), expectedGreenValue);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El valor del color verde debe estar entre 0 y 255")]
        public void ThrowsExceptionWhenAskedForTooLowGreen()
        {
            var invalidGreenVector = new RGBVector(0.15, 1, 0.5);
            invalidGreenVector.Y = -1;
            var green = invalidGreenVector.Green();
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El valor del color verde debe estar entre 0 y 255")]
        public void ThrowsExceptionWhenAskedForTooHighGreen()
        {
            var invalidGreenVector = new RGBVector(0.15, 1, 0.5);
            invalidGreenVector.Y = 2;
            var green = invalidGreenVector.Green();
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectBlueColor()
        {
            var expectedBlueValue = 26;
            Assert.AreEqual(Math.Round(someColorVector.Blue(), NumberOfDecimals), expectedBlueValue);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El valor del color azul debe estar entre 0 y 255")]
        public void ThrowsExceptionWhenAskedForTooLowBlue()
        {
            var invalidBlueVector = new RGBVector(0.15, 0.2, 1);
            invalidBlueVector.Z = -1;
            var blue = invalidBlueVector.Blue();
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El valor del color azul debe estar entre 0 y 255")]
        public void ThrowsExceptionWhenAskedForTooHighBlue()
        {
            var invalidBlueVector = new RGBVector(0.15, 0.2, 1);
            invalidBlueVector.Z = 2;
            var blue = invalidBlueVector.Blue();
        }

        [TestMethod]
        public void GivenNumberDifferentFromZeroDivisionIsCorrect()
        {
            var expectedX = 0.12;
            var expectedY = 0.3;
            var expectedZ = 0.04;

            var result = someColorVector.DivideColor(2.4);

            Assert.IsNotNull(result);
            Assert.AreEqual(Math.Round(result.X, NumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, NumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, NumberOfDecimals), expectedZ);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "No es posible dividir entre 0")]
        public void ThrowsExceptionWhenTryingToDivideByZero()
        {
            var result = someColorVector.DivideColor(0);
        }
    }
}
