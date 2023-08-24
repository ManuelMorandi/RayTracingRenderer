using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Tests
{
    [TestClass]
    public class MetallicTests
    {

        private const string ValidName = "Meta";
        private RGBVector ColorVector = new RGBVector(0, 0.55, 1);
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private User ValidUser = new User()
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTimeProvider.Now
        };
        private const double ValidRoughness = 2.5;

        private Metallic someMaterial;

        [TestInitialize]
        public void TestInit()
        {
            someMaterial = new Metallic()
            {
                Name = ValidName,
                Owner = ValidUser,
                Color = ColorVector,
                Roughness = ValidRoughness
            };
        }

        [TestMethod]
        public void CreateMetallicSuccessful()
        {
            Metallic metallicExample = new Metallic()
            {
                Name = ValidName,
                Owner = ValidUser,
                Color = ColorVector,
                Roughness = ValidRoughness
            };

            Assert.IsNotNull(metallicExample);
            Assert.AreEqual(metallicExample.Name, ValidName);
            Assert.AreEqual(metallicExample.Owner, ValidUser);
            Assert.AreEqual(metallicExample.Color.X, ColorVector.X);
            Assert.AreEqual(metallicExample.Color.Y, ColorVector.Y);
            Assert.AreEqual(metallicExample.Color.Z, ColorVector.Z);
            Assert.AreEqual(metallicExample.Roughness, ValidRoughness);
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
            var StartsWithSpaceName = " Meta";
            someMaterial.Name = StartsWithSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede terminar con un espacio")]
        public void ThrowsExceptionWhenGivenNameEndingWithBlankSpace()
        {
            var EndsWithSpaceName = "Meta ";
            someMaterial.Name = EndsWithSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El difuminado debe ser un valor positivo")]
        public void ThrowsExceptionWhenGivenNegativeRoughness()
        {
            var NegativeRoughness = -1.0;
            someMaterial.Roughness = NegativeRoughness;
        }

        [TestMethod]
        public void ValidMetallicReturnsCorrectColor()
        {
            Assert.AreEqual(someMaterial.GetColor(), ColorVector);
        }

        [TestMethod]
        public void GivenValidMetallicReturnedDescriptionIsCorrect()
        {
            var expectedDescription = "R: 0 G: 140 B: 255 Difuminado: 2,5";
            var returnedDesription = someMaterial.GetDescription();
            Assert.AreEqual(expectedDescription, returnedDesription);
        }
    }
}
