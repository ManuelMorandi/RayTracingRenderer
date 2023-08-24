using ObligatorioFernandezMorandi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MaterialTests
{
    [TestClass]
    public class LambertianTests
    {

        private const string ValidName = "Lambi";

        private RGBVector ColorVector = new RGBVector(0, 0.55, 1);
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private DateTime ValidDate = DateTime.Today;
        private User ValidUser = new User()
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTime.Today, // No anda con ValidDate, verificar
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
        [ExpectedException(typeof(BusinessLogicException), "The material must have a name")]
        public void ThrowsExceptionWhenGivenBlankName()
        {
            var NullName = "";
            someMaterial.Name = NullName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "The name must not start with a blank space")]
        public void ThrowsExceptionWhenGivenNameBeginningWithBlankSpace()
        {
            var StartsWithSpaceName = " Lambi";
            someMaterial.Name = StartsWithSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "The name must not end with a blank space")]
        public void ThrowsExceptionWhenGivenNameEndingWithBlankSpace()
        {
            var EndsWithSpaceName = "Lambi ";
            someMaterial.Name = EndsWithSpaceName;
        }
    }
}
