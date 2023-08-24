using ObligatorioFernandezMorandi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RayTests
{
    [TestClass]
    public class RayTests
    {
        Vector origin = new Vector(-2.25, 0, 0.1);
        Vector direction = new Vector(1, 2, 3);

        Ray someRay;

        [TestInitialize]
        public void TestInit()
        {
            someRay = new Ray()
            {
                Origin = origin,
                Direction = direction,
            };
        }

        [TestMethod]
        public void CreateRaySuccessTest()
        {
            Ray ray = new Ray()
            {
                Origin = origin,
                Direction = direction,
            };

            Assert.IsNotNull(ray);
            Assert.AreEqual(origin, ray.Origin);
            Assert.AreEqual(direction, ray.Direction);
        }

        [TestMethod]
        public void GivenValidValueReturnsCorrectPointAt()
        {
            Vector result = someRay.PointAt(5.2);
            Assert.AreEqual(Math.Round(result.X, 2), 2.95);
            Assert.AreEqual(Math.Round(result.Y, 2), 10.4);
            Assert.AreEqual(Math.Round(result.Z, 2), 15.7);
        }
    }
}
