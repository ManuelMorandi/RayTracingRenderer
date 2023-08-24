using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class SphereTests
    {
        private const string ValidName = "Bola grande";
        private const double ValidRadius = 2.5;
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private User ValidUser = new User() 
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTimeProvider.Now,
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
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede ser vacío")]
        public void NameIsNull()
        {
            var NullName = "";
            someSphere.Name = NullName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede empezar con un espacio")]
        public void NameStartsBlank()
        {
            var StartingSpaceName = " Bola";
            someSphere.Name = StartingSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede terminar con un espacio")]
        public void NameEndsBlank()
        {
            var EndingSpaceName = "Bola ";
            someSphere.Name = EndingSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El radio debe ser mayor a 0")]
        public void RadiusIsNegative()
        {
            var NegativeRadius = -1;
            someSphere.Radius = NegativeRadius;
        }

        [TestMethod]
        public void GivenValidSphereReturnedDescriptionIsCorrect()
        {
            var expectedDescription = "Radio: 2,5";
            var returnedDesription = someSphere.GetDescription();
            Assert.AreEqual(expectedDescription, returnedDesription);
        }
    }
}
