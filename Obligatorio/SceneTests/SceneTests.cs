using ObligatorioFernandezMorandi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SceneTests
{
    [TestClass]
    public class SceneTests
    {
        private const string ValidName = "Primer Escena";
        private DateTime ValidSceneCreationDate = DateTime.Today;
        private DateTime ValidSceneModificationDate = DateTime.Today;
        private DateTime ValidSceneRenderDate = DateTime.Today;
        private Vector DefaultLookFrom = new Vector(0, 2, 0);
        private Vector DefaultLookAt = new Vector(0, 2, 5);
        private int DefaultFov = 30;
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private DateTime ValidDate = DateTime.Today;
        private User ValidUser = new User()
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTime.Today, // No anda con ValidDate, verificar
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
                //CreationDate = ValidSceneCreationDate,
                Models = ValidModels,
                //ModifiedDate = ValidModificationDate,
                //RenderedDate = ValidRenderDate,
                LookFrom = DefaultLookFrom,
                LookAt = DefaultLookAt,
                Fov = DefaultFov,
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
            var scene = new Scene()
            {
                Owner = ValidUser,
                Name = ValidName,
                //CreationDate = ValidSceneCreationDate,
                Models = ValidModels,
                //ModifiedDate = ValidModificationDate,
                //RenderedDate = ValidRenderDate,
                Preview = ValidPreview,
            };

            Assert.IsNotNull(scene);
            Assert.AreEqual(scene.Owner, ValidUser);
            Assert.AreEqual(scene.Name, ValidName);
            Assert.AreEqual(scene.Models, ValidModels);
            Assert.AreEqual(scene.LookFrom.X, DefaultLookFrom.X);
            Assert.AreEqual(scene.LookFrom.Y, DefaultLookFrom.Y);
            Assert.AreEqual(scene.LookFrom.Z, DefaultLookFrom.Z);
            Assert.AreEqual(scene.LookAt.X, DefaultLookAt.X);
            Assert.AreEqual(scene.LookAt.Y, DefaultLookAt.Y);
            Assert.AreEqual(scene.LookAt.Z, DefaultLookAt.Z);
            Assert.AreEqual(scene.Fov, DefaultFov);
            Assert.AreEqual(scene.Preview, ValidPreview);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "The scene must have a name")]
        public void ThrowsExceptionWhenGivenBlankName()
        {
            var NullName = "";
            someScene.Name = NullName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "The name must not start with a blank space")]
        public void ThrowsExceptionWhenGivenNameBeginningWithBlankSpace()
        {
            var StartsWithSpaceName = " Primer Scena";
            someScene.Name = StartsWithSpaceName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "The name must not end with a blank space")]
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
            ValidModels.Add(exampleModel);
            Assert.IsTrue(ValidModels.Contains(exampleModel));
        }

        [TestMethod]
        public void GivenAModelItGetsRemovedFromList()
        {
            ValidModels.Remove(someUsedModel);
            Assert.IsTrue(!ValidModels.Contains(someUsedModel));
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
        [ExpectedException(typeof(BusinessLogicException), "Field of vision must be a whole number between 1 and 160")]
        public void GivenLowerThanAcceptableFOVItThrowsException()
        {
            var invalidLowFOV = 0;
            someScene.Fov = invalidLowFOV;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Field of vision must be a whole number between 1 and 160")]
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
    }
}
