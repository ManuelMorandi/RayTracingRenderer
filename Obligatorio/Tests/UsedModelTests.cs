using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UsedModelTests
    {
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private User ValidUser = new User()
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTimeProvider.Now,
        };

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

        private Vector ValidPosition = new Vector(0, 2000, -1);

        private const string ValidName = "Planeta";
        private const string ValidPreview = "ExamplePreviewImageDirectory";

        private Model someModel;

        [TestInitialize]
        public void TestInit()
        {
            ValidShape.Owner = ValidUser;
            ValidMaterial.Owner = ValidUser;
            ValidMaterial.Color = ValidColor;

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
        public void CreateUsedModelSuccessTest()
        {
            UsedModel usedModel = new UsedModel()
            {
                SelectedModel = someModel,
                Place = ValidPosition,
            };

            Assert.IsNotNull(usedModel);
            Assert.AreEqual(usedModel.SelectedModel, someModel);
            Assert.AreEqual(usedModel.Place, ValidPosition);
        }
    }
}