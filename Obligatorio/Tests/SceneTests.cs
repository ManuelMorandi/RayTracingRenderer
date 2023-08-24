using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class SceneTests
    {
        private const string ValidName = "Primer Escena";
        private DateTime ValidSceneCreationDate = DateTimeProvider.Now;
        private DateTime ValidSceneModificationDate = DateTimeProvider.Now;
        private DateTime ValidSceneRenderDate = DateTimeProvider.Now;
        private Vector DefaultLookFrom = new Vector(0, 2, 0);
        private Vector DefaultLookAt = new Vector(0, 2, 5);
        private int DefaultFov = 30;
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private User ValidUser = new User()
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTimeProvider.Now, 
        };

        private const string ValidModelName = "Planeta";
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

        private const string ValidRender = "ExampleValidRender";
        private const string ValidPreview = "ExamplePreviewImageDirectory";

        List<UsedModel> ValidModels = new List<UsedModel>();

        private Vector ValidPosition = new Vector(0, 2000, -1);

        private Scene someScene;
        private Model someModel;
        private UsedModel someUsedModel;

        [TestInitialize]
        public void TestInit()
        {
            ValidShape.Owner = ValidUser;
            ValidMaterial.Owner = ValidUser;
            ValidMaterial.Color = ValidColor;

            someModel = new Model()
            {
                Owner = ValidUser,
                Name = ValidModelName,
                ModelShape = ValidShape,
                ModelMaterial = ValidMaterial,
                Preview = ValidPreview,
            };

            someScene = new Scene()
            {
                Owner = ValidUser,
                Name = ValidName,
                CreationDate = ValidSceneCreationDate,
                Models = ValidModels,
                LastModificationDate = ValidSceneModificationDate,
                LastRenderDate = ValidSceneRenderDate,
                LookFrom = DefaultLookFrom,
                LookAt = DefaultLookAt,
                Fov = DefaultFov,
                Render = ValidRender,
                Preview = ValidPreview,
            };

            someUsedModel = new UsedModel()
            {
                SelectedModel = someModel,
                Place = ValidPosition,
            };
        }

        [TestMethod]
        public void CreateSceneSuccessTest()
        {
            var someDate = DateTime.Now;
            DateTimeProvider.Now = someDate;
            var scene = new Scene()
            {
                Owner = ValidUser,
                Name = ValidName,
                CreationDate = DateTimeProvider.Now,
                Models = ValidModels,
                LastModificationDate = DateTimeProvider.Now,
                LastRenderDate = DateTimeProvider.Now,
                Render = ValidRender,
                Preview = ValidPreview,
            };

            Assert.IsNotNull(scene);
            Assert.AreEqual(scene.Owner, ValidUser);
            Assert.AreEqual(scene.Name, ValidName);
            Assert.AreEqual(scene.Models, ValidModels);
            Assert.AreEqual(scene.LookFrom, DefaultLookFrom);
            Assert.AreEqual(scene.LookAt, DefaultLookAt);
            Assert.AreEqual(scene.Fov, DefaultFov);
            Assert.AreEqual(scene.Preview, ValidPreview);
            Assert.AreEqual(scene.CreationDate, someDate);
            Assert.AreEqual(scene.LastModificationDate, someDate);
            Assert.AreEqual(scene.Render, ValidRender);
            Assert.AreEqual(scene.LastRenderDate, someDate);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede ser vacío")]
        public void ThrowsExceptionWhenGivenBlankName()
        {
            var NullName = "";
            someScene.Name = NullName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede empezar con un espacio")]
        public void ThrowsExceptionWhenGivenNameBeginningWithBlankSpace()
        {
            var StartsWithSpaceName = " Primer Scena";
            someScene.Name = StartsWithSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre no puede terminar con un espacio")]
        public void ThrowsExceptionWhenGivenNameEndingWithBlankSpace()
        {
            var EndsWithSpaceName = "Primer Escena ";
            someScene.Name = EndsWithSpaceName;
        }

        [TestMethod]
        public void GivenAModelItGetsAddedToList()
        {
            Vector exampleVector = new Vector(-5, 2, 0.5);
            UsedModel exampleModel = new UsedModel()
            {
                SelectedModel = someModel,
                Place = exampleVector,
            };
            someScene.AddModel(exampleModel);
            Assert.IsTrue(someScene.Models.Contains(exampleModel));
        }

        [TestMethod]
        public void GivenAModelItGetsRemovedFromList()
        {
            Vector exampleVector = new Vector(-5, 2, 0.5);
            UsedModel exampleModel = new UsedModel()
            {
                SelectedModel = someModel,
                Place = exampleVector,
            };
            someScene.AddModel(exampleModel);
            someScene.RemoveModel(exampleModel);
            Assert.IsFalse(someScene.Models.Contains(exampleModel));
        }

        [TestMethod]
        public void Given1ItUpdatesFOV()
        {
            var minAcceptedValue = 1;
            someScene.Fov = minAcceptedValue;
            Assert.AreEqual(minAcceptedValue, someScene.Fov);
        }

        [TestMethod]
        public void Given160ItUpdatesFOV()
        {
            var maxAcceptedValue = 160;
            someScene.Fov = maxAcceptedValue;
            Assert.AreEqual(maxAcceptedValue, someScene.Fov);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El campo de vision (FOV) debe ser un número entero entre 1 y 160")]
        public void GivenLowerThanAcceptableFOVItThrowsException()
        {
            var invalidLowFOV = 0;
            someScene.Fov = invalidLowFOV;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El campo de vision (FOV) debe ser un número entero entre 1 y 160")]
        public void GivenHigherThanAcceptableFOVItThrowsException()
        {
            var invalidHighFOV = 161;
            someScene.Fov = invalidHighFOV;
        }

        [TestMethod]
        public void GivenValidVectorUpdatesLookFrom()
        {
            Vector exampleVector = new Vector(-5, 2, 0.5);
            someScene.LookFrom = exampleVector;
            Assert.AreEqual(someScene.LookFrom, exampleVector);
        }


        [TestMethod]
        public void GivenValidVectorUpdatesLookAt()
        {
            Vector exampleVector = new Vector(-5, 2, 0.5);
            someScene.LookAt = exampleVector;
            Assert.AreEqual(someScene.LookAt, exampleVector);
        }

        [TestMethod]
        public void GivenValidSceneReturnedDescriptionIsCorrect()
        {
            var expectedDescription = "Última modificación: " + someScene.LastModificationDate;
            var returnedDesription = someScene.GetDescription();
            Assert.AreEqual(expectedDescription, returnedDesription);
        }

        [TestMethod]
        public void SettingBlurredSceneWorksCorrectly()
        {
            someScene.Blurred = true;
            Assert.IsTrue(someScene.Blurred);
        }

        [TestMethod]
        public void GivenValidApertureItGetsSet()
        {
            double validValue = 1.5;
            someScene.Aperture = validValue;
            Assert.AreEqual(validValue, someScene.Aperture);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "La apertura debe ser mayor a 0 y menor o igual a 3")]
        public void GivenLowerThanAcceptableApertureThrowsException()
        {
            double invalidValue = 0.0;
            someScene.Aperture = invalidValue;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "La apertura debe ser mayor a 0 y menor o igual a 3")]
        public void GivenHigherThanAcceptableApertureThrowsException()
        {
            double invalidValue = 3.1;
            someScene.Aperture = invalidValue;
        }

        [TestMethod]
        public void GivenApertureWithMultipleDecimalsGetsRoundedCorrectly()
        {
            double invalidValue = 1.52;
            double expectedValue = 1.5;
            someScene.Aperture = invalidValue;
            Assert.AreEqual(expectedValue, someScene.Aperture);
        }
    }
}
