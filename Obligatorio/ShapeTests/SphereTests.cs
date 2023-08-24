using ObligatorioFernandezMorandi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapeTests
{
    [TestClass]
    public class SphereTests
    {
        private const string ValidName = "Bola grande";
        private const double ValidRadius = 2.5;
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private DateTime ValidDate = DateTime.Today; 
        private User ValidUser = new User() 
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTime.Today, // No anda con ValidDate, verificar
        };
        
        private Sphere someSphere;

        [TestInitialize]
        public void TestInit()
        {
            someSphere = new Sphere()
            {
                Name = ValidName,
                Radius = ValidRadius,
                Owner = ValidUser,
            };
        }

        [TestMethod]
        public void CreateSphereSuccessTest()
        {
            var sphere = new Sphere()
            {
                Name = ValidName,
                Radius = ValidRadius,
                Owner = ValidUser, 
            };

            Assert.IsNotNull(sphere);
            Assert.AreEqual(sphere.Name, ValidName);
            Assert.AreEqual(sphere.Radius, ValidRadius);
            Assert.AreEqual(sphere.Owner, ValidUser); 
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Shape name is empty")]
        public void NameIsNull()
        {
            var NullName = "";
            someSphere.Name = NullName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Shape name must not start with a blank space")]
        public void NameStartsBlank()
        {
            var StartingSpaceName = " Bola";
            someSphere.Name = StartingSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Shape name must not end with a blank space")]
        public void NameEndsBlank()
        {
            var EndingSpaceName = "Bola ";
            someSphere.Name = EndingSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Radius must be greater than zero")]
        public void RadiusIsNegative()
        {
            var NegativeRadius = -1;
            someSphere.Radius = NegativeRadius;
        }
    }
}
