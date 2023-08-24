using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class RayTests
    {
        Vector origin = new Vector(-2.25, 0, 0.1);
        Vector direction = new Vector(1, 2, 3);

        private const int NumberOfDecimals = 2;

        Ray someRay;

        [TestInitialize]
        public void TestInit()
        {
            someRay = new Ray(origin, direction);
        }

        [TestMethod]
        public void CreateRaySuccessTest()
        {
            Ray ray = new Ray(origin, direction);

            Assert.IsNotNull(ray);
            Assert.AreEqual(origin, ray.Origin);
            Assert.AreEqual(direction, ray.Direction);
        }

        [TestMethod]
        public void GivenValidValueReturnsCorrectPointAt()
        {
            var input = 5.2;
            var expectedX = 2.95;
            var expectedY = 10.4;
            var expectedZ = 15.7;

            Vector result = someRay.PointAt(input);

            Assert.AreEqual(Math.Round(result.X, NumberOfDecimals), expectedX);
            Assert.AreEqual(Math.Round(result.Y, NumberOfDecimals), expectedY);
            Assert.AreEqual(Math.Round(result.Z, NumberOfDecimals), expectedZ);
        }
    }
}
