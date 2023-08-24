using ObligatorioFernandezMorandi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VectorTests
{
    [TestClass]
    public class VectorTests
    {

        private Vector someVector;

        [TestInitialize]
        public void TestInit()
        {
            someVector = new Vector(3, 7.2, -1);
        }

        [TestMethod]
        public void CreateVectorSuccessTest()
        {
            var vector = new Vector(5.15, 7.0, 2.33);

            Assert.IsNotNull(vector);
            Assert.AreEqual(5.15, Math.Round(vector.X, 2));
            Assert.AreEqual(7, Math.Round(vector.Y,2));  
            Assert.AreEqual(2.33, Math.Round(vector.Z, 2));
        }
        
        [TestMethod]
        public void GivenValidVectorItReturnsCorrectAddition()
        {
            var vector = new Vector(5.15, 7.0, 2.33);
            var result = vector.Add(someVector);
            Assert.AreEqual(8.15, Math.Round(result.X, 2));
            Assert.AreEqual(14.2, Math.Round(result.Y, 2));
            Assert.AreEqual(1.33, Math.Round(result.Z, 2));
        }

        [TestMethod]
        public void GivenValidVectorItReturnsCorrectSubstraction()
        {
            var vector = new Vector(5.15, 7.0, 2.33);
            var result = vector.Subtract(someVector);
            Assert.AreEqual(2.15, Math.Round(result.X, 2));
            Assert.AreEqual(-0.2, Math.Round(result.Y, 2));
            Assert.AreEqual(3.33, Math.Round(result.Z, 2));
        }

        [TestMethod]
        public void GivenValidValueItReturnsCorrectMultiplication()
        {
            var result = someVector.Multiply(5);
            Assert.AreEqual(15, Math.Round(result.X, 2));
            Assert.AreEqual(36, Math.Round(result.Y, 2));
            Assert.AreEqual(-5, Math.Round(result.Z, 2));
        }

        [TestMethod]
        public void GivenValidValueItReturnsCorrectDivision()
        {
            var result = someVector.Divide(-3);
            Assert.AreEqual(-1, Math.Round(result.X, 2));
            Assert.AreEqual(-2.4, Math.Round(result.Y, 2));
            Assert.AreEqual(0.33, Math.Round(result.Z, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Cannot divide by 0")]
        public void GivenZeroDivisionThrowsException()
        {
            var result = someVector.Divide(0);
        }

        [TestMethod]
        public void GivenValidVectorItGetsAddedCorrectly()
        {
            var result = new Vector(3, 0.2, -1);
            result.AddTo(new Vector(8, 23.17, 5));
            Assert.AreEqual(Math.Round(result.X, 2), 11);
            Assert.AreEqual(Math.Round(result.Y, 2), 23.37);
            Assert.AreEqual(Math.Round(result.Z, 2), 4);
        }

        [TestMethod]
        public void GivenValidVectorItGetsSubstractedCorrectly()
        {
            var result = new Vector(3, 7.2, -1);
            result.SubstractFrom(new Vector(8, 23.17, 5));
            Assert.AreEqual(Math.Round(result.X, 2), -5);
            Assert.AreEqual(Math.Round(result.Y, 2), -15.97);
            Assert.AreEqual(Math.Round(result.Z, 2), -6);
        }

        [TestMethod]
        public void GivenValidValueItGetsMultipliedCorrectly()
        {
            var result = new Vector(3, 7.2, -1);
            result.ScaleUpBy(3);
            Assert.AreEqual(Math.Round(result.X, 2), 9);
            Assert.AreEqual(Math.Round(result.Y, 2), 21.6);
            Assert.AreEqual(Math.Round(result.Z, 2), -3);
        }

        [TestMethod]
        public void GivenValidValueItGetsDividedCorrectly()
        {
            var result = new Vector(3, 7.2, -1);
            result.ScaleDownBy(5);
            Assert.AreEqual(Math.Round(result.X, 2), 0.6);
            Assert.AreEqual(Math.Round(result.Y, 2), 1.44);
            Assert.AreEqual(Math.Round(result.Z, 2), -0.2);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Cannot divide by 0")]
        public void GivenZeroScalingDownThrowsException()
        {
            var result = new Vector(3, 7.2, -1);
            result.ScaleDownBy(0);
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectUnit()
        {
            var result = someVector.GetUnit();
            Assert.AreEqual(Math.Round(result.X, 2), 0.38); // 3 / Math.Sqrt(61.84)
            Assert.AreEqual(Math.Round(result.Y, 2), 0.92); // 7.2 / Math.Sqrt(61.84)
            Assert.AreEqual(Math.Round(result.Z, 2), -0.13); // -1 / Math.Sqrt(61.84)
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectDot()
        {
            var vector3d = new Vector(-2, 3, 5.1);
            double result = someVector.Dot(vector3d);
            Assert.AreEqual(Math.Round(result, 4), 10.5);
        }

        [TestMethod]
        public void GivenValidVectorReturnsCorrectCross()
        {
            var vector3d = new Vector(-2, 3, 5.1);
            var result = someVector.Cross(vector3d);
            Assert.AreEqual(Math.Round(result.X, 2), 39.72);
            Assert.AreEqual(Math.Round(result.Y, 2), -13.3);
            Assert.AreEqual(Math.Round(result.Z, 2), 23.4);
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectLength()
        {
            Assert.AreEqual(Math.Sqrt(61.84), someVector.Length());
        }

        [TestMethod]
        public void ValidVectorReturnsCorrectSquaredLength()
        {
            Assert.AreEqual(61.84, Math.Round(someVector.SquaredLength(), 4));
        }
    }
}
