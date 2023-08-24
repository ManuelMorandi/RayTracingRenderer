using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class LambertianTests
    {

        private const string ValidName = "Lambi";

        private RGBVector ColorVector = new RGBVector(0, 0.55, 1);
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private User ValidUser = new User()
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTimeProvider.Now
        };

        private Lambertian someMaterial;

        [TestInitialize]
        public void TestInit()
        {
            someMaterial = new Lambertian()
            {
                Name = ValidName,
                Owner = ValidUser,
                Color = ColorVector,
            };
        }

        [TestMethod]
        public void CreateLambertianSuccessful()
        {
            Lambertian lambertianExample = new Lambertian()
            {
                Name = ValidName,
                Owner = ValidUser,
                Color = ColorVector,
            };

            Assert.IsNotNull(lambertianExample);
            Assert.AreEqual(lambertianExample.Name, ValidName);
            Assert.AreEqual(lambertianExample.Owner, ValidUser);
            Assert.AreEqual(lambertianExample.Color.X, ColorVector.X);
            Assert.AreEqual(lambertianExample.Color.Y, ColorVector.Y);
            Assert.AreEqual(lambertianExample.Color.Z, ColorVector.Z);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede ser vacío")]
        public void ThrowsExceptionWhenGivenBlankName()
        {
            var NullName = "";
            someMaterial.Name = NullName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede empezar con un espacio")]
        public void ThrowsExceptionWhenGivenNameBeginningWithBlankSpace()
        {
            var StartsWithSpaceName = " Lambi";
            someMaterial.Name = StartsWithSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede terminar con un espacio")]
        public void ThrowsExceptionWhenGivenNameEndingWithBlankSpace()
        {
            var EndsWithSpaceName = "Lambi ";
            someMaterial.Name = EndsWithSpaceName;
        }

        [TestMethod]
        public void ValidLambertianReturnsCorrectColor()
        {
            Assert.AreEqual(someMaterial.GetColor(), ColorVector);
        }

        [TestMethod]
        public void GivenValidLambertianReturnedDescriptionIsCorrect()
        {
            var expectedDescription = "R: 0 G: 140 B: 255";
            var returnedDesription = someMaterial.GetDescription();
            Assert.AreEqual(expectedDescription, returnedDesription);
        }
    }
}
