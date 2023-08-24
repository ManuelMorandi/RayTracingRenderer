using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class ModelTests
    {
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private User ValidUser = new User()
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTimeProvider.Now,
        };

        private const string ValidName = "Planeta";
        private const string ValidSphereName = "Bola";
        private const double ValidRadius = 200.5;
        private Sphere ValidShape = new Sphere()
        {
            Name = ValidSphereName,
            Radius = ValidRadius,
        };

        private const string ValidLambertianName = "Gris";
        private RGBVector ValidColor = new RGBVector(0.5, 0.5, 0.5);
        private Lambertian ValidMaterial = new Lambertian()
        {
            Name = ValidLambertianName
        };

        private const string ValidPreview = "ExamplePreviewImageDirectory";

        private const string DifferentUserName = "JoseLuisEsparta";
        private const string DifferentPassword = "JoseTQM123";
        private User DifferentUser = new User()
        {
            UserName = DifferentUserName,
            Password = DifferentPassword,
            Creation = DateTimeProvider.Now,
        };

        private const string DifferentName = "Joya";
        private const string DifferentSphereName = "Canica";
        private const double DifferentRadius = 0.15;
        private Sphere DifferentShape = new Sphere()
        {
            Name = DifferentSphereName,
            Radius = DifferentRadius,
        };

        private const string DifferentLambertianName = "Blanco";
        private RGBVector DifferentColor = new RGBVector(0, 0, 0);
        private Lambertian DifferentMaterial = new Lambertian()
        {
            Name = DifferentLambertianName,
        };

        private Model someModel;

        [TestInitialize]
        public void TestInit()
        {
            ValidShape.Owner = ValidUser;
            ValidMaterial.Owner = ValidUser;
            ValidMaterial.Color = ValidColor;
            DifferentShape.Owner = DifferentUser;
            DifferentMaterial.Owner = DifferentUser;
            DifferentMaterial.Color = DifferentColor;

            someModel = new Model()
            {
                Owner = ValidUser,
                Name = ValidName,
                ModelShape = ValidShape,
                ModelMaterial = ValidMaterial,
                Preview = ValidPreview,
            };
        }

        [TestMethod]
        public void CreateModelSuccessTest()
        {
            var model = new Model()
            {
                Owner = ValidUser,
                Name = ValidName,
                ModelShape = ValidShape,
                ModelMaterial = ValidMaterial,
                Preview = ValidPreview,

            };

            Assert.IsNotNull(model);
            Assert.AreEqual(model.Owner, ValidUser);
            Assert.AreEqual(model.Name, ValidName);
            Assert.AreEqual(model.ModelShape, ValidShape);
            Assert.AreEqual(model.ModelMaterial, ValidMaterial);
            Assert.AreEqual(model.Preview, ValidPreview);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede ser vacío")]
        public void NameIsNull()
        {
            var NullName = "";
            someModel.Name = NullName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede empezar con un espacio")]
        public void NameStartsBlank()
        {
            var StartingSpaceName = " Planeta";
            someModel.Name = StartingSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede terminar con un espacio")]
        public void NameEndsBlank()
        {
            var EndingSpaceName = "Planeta ";
            someModel.Name = EndingSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El dueño de la figura debe coincidir con el dueño del modelo")]
        public void ChangingShapeToOneNotOwnedByUserThrowsException()
        {
            Model modelWithIncorrectShape = new Model()
            {
                Owner = ValidUser,
                Name = DifferentName,
                ModelShape = ValidShape,
                ModelMaterial = ValidMaterial,
                Preview = ValidPreview,
            };
            modelWithIncorrectShape.ModelShape = DifferentShape;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El dueño del material debe coincidir con el dueño del modelo")]
        public void ChangingMaterialToOneNotOwnedByUserThrowsException()
        {
            Model modelWithIncorrectMaterial = new Model()
            {
                Owner = ValidUser,
                Name = DifferentName,
                ModelShape = ValidShape,
                ModelMaterial = ValidMaterial,
                Preview = ValidPreview,
            };
            modelWithIncorrectMaterial.ModelMaterial = DifferentMaterial;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El dueño de la figura debe coincidir con el dueño del modelo")]
        public void ChangingOwnerToOneDifferentToThatOfShapeThrowsException()
        {
            Model differentShapeModel = new Model()
            {
                Name = DifferentName,
                ModelShape = ValidShape,
                ModelMaterial = DifferentMaterial,
                Preview = ValidPreview,
                Owner = DifferentUser,
            };
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El dueño del material debe coincidir con el dueño del modelo")]
        public void ChangingOwnerToOneDifferentToThatOfMaterialThrowsException()
        {
            Model differentShapeModel = new Model()
            {
                Name = DifferentName,
                ModelShape = DifferentShape,
                ModelMaterial = ValidMaterial,
                Preview = ValidPreview,
                Owner = DifferentUser,
            };
        }

        [TestMethod]
        public void GivenValidModelReturnsCorrectDescription()
        {
            var expectedOutput = "Figura: Bola, Material: Gris";
            Assert.AreEqual(someModel.GetDescription(), expectedOutput);
        }

        [TestMethod]
        public void GivenValidModelReturnCorrectString()
        {

            Assert.AreEqual(someModel.ToString(), ValidName);
        }
    }
}
