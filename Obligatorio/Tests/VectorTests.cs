using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class VectorTests
    {
        private const int LowNumberOfDecimals = 2;
        private const int HighNumberOfDecimals = 4;

        private Vector someVector;

        [TestInitialize]
        public void TestInit()
        {
            someVector = new Vector(3, 7.2, -1);
        }

        [TestMethod]
        public void CreateVectorSuccessTest()
        {
            var expectedX = 5.15;
            var expectedY = 7;
            var expectedZ = 2.33;

            var vector = new Vector(expectedX, expectedY, expectedZ);

            Assert.IsNotNull(vector);
            Assert.AreEqual(Math.Round(vector.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(vector.Y, LowNumberOfDecimals), expectedY);  
            Assert.AreEqual(Math.Round(vector.Z, LowNumberOfDecimals), expectedZ);
        }
        
        [TestMethod]
        public void GivenValidVectorItReturnsCorrectAddition()
        {
            var expectedX = 8.15;
            var expectedY = 14.2;
            var expectedZ = 1.33;

            var vector = new Vector(5.15, 7.0, 2.33);
            var result = vector.Add(someVector);

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ);
        }

        [TestMethod]
        public void GivenValidVectorItReturnsCorrectSubstraction()
        {
            var expectedX = 2.15;
            var expectedY = -0.2;
            var expectedZ = 3.33;

            var vector = new Vector(5.15, 7.0, 2.33);
            var result = vector.Subtract(someVector);

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ);
        }

        [TestMethod]
        public void GivenValidValueItReturnsCorrectMultiplication()
        {
            var input = 5;
            var expectedX = 15;
            var expectedY = 36;
            var expectedZ = -5;

            var result = someVector.Multiply(input);

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ);
        }

        [TestMethod]
        public void GivenValidValueItReturnsCorrectDivision()
        {
            var input = -3;
            var expectedX = -1;
            var expectedY = -2.4;
            var expectedZ = 0.33;

            var result = someVector.Divide(input);

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "No se puede dividir entre 0")]
        public void GivenZeroDivisionThrowsException()
        {
            var result = someVector.Divide(0);
        }

        [TestMethod]
        public void GivenValidVectorItGetsAddedCorrectly()
        {
            var expectedX = 11;
            var expectedY = 23.37;
            var expectedZ = 4;

            var result = new Vector(3, 0.2, -1);
            result.AddTo(new Vector(8, 23.17, 5));

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ);
        }

        [TestMethod]
        public void GivenValidVectorItGetsSubstractedCorrectly()
        {
            var expectedX = -5;
            var expectedY = -15.97;
            var expectedZ = -6;

            var result = new Vector(3, 7.2, -1);
            result.SubstractFrom(new Vector(8, 23.17, 5));

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ);
        }

        [TestMethod]
        public void GivenValidValueItGetsMultipliedCorrectly()
        {
            var input = 3;
            var expectedX = 9;
            var expectedY = 21.6;
            var expectedZ = -3;

            var result = new Vector(3, 7.2, -1);
            result.ScaleUpBy(input);

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ);
        }

        [TestMethod]
        public void GivenValidValueItGetsDividedCorrectly()
        {
            var input = 5;
            var expectedX = 0.6;
            var expectedY = 1.44;
            var expectedZ = -0.2;

            var result = new Vector(3, 7.2, -1);
            result.ScaleDownBy(input);

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "No se puede dividir entre 0")]
        public void GivenZeroScalingDownThrowsException()
        {
            var result = new Vector(3, 7.2, -1);
            result.ScaleDownBy(0);
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectUnit()
        {
            var expectedX = 0.38;
            var expectedY = 0.92;
            var expectedZ = -0.13;

            var result = someVector.GetUnit();

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX); 
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY); 
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ); 
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectDot()
        {
            var expectedOutput = 10.5;

            var vector3d = new Vector(-2, 3, 5.1);
            double result = someVector.Dot(vector3d);

            Assert.AreEqual(Math.Round(result, HighNumberOfDecimals), expectedOutput);
        }

        [TestMethod]
        public void GivenValidVectorReturnsCorrectCross()
        {
            var expectedX = 39.72;
            var expectedY = -13.3;
            var expectedZ = 23.4;

            var vector3d = new Vector(-2, 3, 5.1);
            var result = someVector.Cross(vector3d);

            Assert.AreEqual(Math.Round(result.X, LowNumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, LowNumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, LowNumberOfDecimals), expectedZ);
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectLength()
        {
            var expectedOutput = Math.Sqrt(61.84);
            Assert.AreEqual(someVector.Length(), expectedOutput);
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectSquaredLength()
        {
            var expectedOutput = 61.84;
            Assert.AreEqual(Math.Round(someVector.SquaredLength(), HighNumberOfDecimals), expectedOutput);
        }

        [TestMethod]
        public void ToStringReturnsExpectedOutput()
        {
            var expectedOutput = "(3, 7,2, -1)";
            Assert.AreEqual(someVector.ToString(), expectedOutput);
        }

        [TestMethod]
        public void GivenSameVectorEqualsReturnsTrue()
        {
            var newVector = new Vector(3, 7.2, -1);
            Assert.IsTrue(newVector.Equals(someVector));
        }

        [TestMethod]
        public void GivenDifferentXVectorEqualsReturnsFalse()
        {
            var newVector = new Vector(5, 7.2, -1);
            Assert.IsFalse(newVector.Equals(someVector));
        }

        [TestMethod]
        public void GivenDifferentYVectorEqualsReturnsFalse()
        {
            var newVector = new Vector(3, 3, -1);
            Assert.IsFalse(newVector.Equals(someVector));
        }

        [TestMethod]
        public void GivenDifferentZVectorEqualsReturnsFalse()
        {
            var newVector = new Vector(3, 7.2, 3);
            Assert.IsFalse(newVector.Equals(someVector));
        }
    }
}
