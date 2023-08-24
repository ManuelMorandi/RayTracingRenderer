using Domain;
using Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class RendererTests
    {

        private int ValidResX = 10;
        private int ValidResY = 10;
        private Vector ValidUp = new Vector(0, 1, 0);
        private Scene someScene;
        private const string ValidName = "Primer Escena";
        private const string ValidUserName = "JavierMilan";
        private const string ValidPassword = "JaviMilan13";
        private User ValidUser = new User()
        {
            UserName = ValidUserName,
            Password = ValidPassword,
            Creation = DateTimeProvider.Now,
        };
        private string ValidPreview = "Preview1";
        private Renderer someRenderer;
        private const string ValidModelName = "Planeta";
        private const string ValidSphereName = "Bola";
        private const double ValidRadius = 0.5;
        private Sphere ValidShape = new Sphere()
        {
            Name = ValidSphereName,
            Radius = ValidRadius,
        };
        private const string ValidLambertianName = "Color";
        private RGBVector ValidColor = new RGBVector(0.1, 0.2, 0.5);
        private Lambertian ValidMaterial = new Lambertian()
        {
            Name = ValidLambertianName
        };
        private UsedModel someUsedModel;
        private Vector ValidPlace = new Vector(0, 2, 5);
        private Model someModel;
        private List<UsedModel> ValidModelList;

        private Renderer someRenderer2;
        private const string ValidName2 = "Segunda Escena";
        private Scene someScene2;
        private const string ValidSphereName2 = "Esfera2";
        private const double ValidRadius2 = 2;
        private Sphere ValidShape2 = new Sphere()
        {
            Name = ValidSphereName2,
            Radius = ValidRadius2,
        };
        private const string ValidLambertianName2 = "Color2";
        private RGBVector ValidColor2 = new RGBVector(0.8, 0.25, 0.05);
        private Lambertian ValidMaterial2 = new Lambertian()
        {
            Name = ValidLambertianName2
        };
        private const string ValidSphereName3 = "Esfera3";
        private const double ValidRadius3 = 2000;
        private Sphere ValidShape3 = new Sphere()
        {
            Name = ValidSphereName3,
            Radius = ValidRadius3,
        };
        private const string ValidLambertianName3 = "Color3";
        private RGBVector ValidColor3 = new RGBVector(0.8, 0.7, 0.6);
        private Lambertian ValidMaterial3 = new Lambertian()
        {
            Name = ValidLambertianName3
        };
        private UsedModel someUsedModel1;
        private UsedModel someUsedModel2;
        private UsedModel someUsedModel3;
        private Model someModel1;
        private Model someModel2;
        private Model someModel3;
        private Vector ValidPlace1 = new Vector(0, 0.5, -2);
        private Vector ValidPlace2 = new Vector(-1, 2, -10);
        private Vector ValidPlace3 = new Vector(0, -2000, -1);
        private const string ValidModelName1 = "Modelo1";
        private const string ValidModelName2 = "Modelo2";
        private const string ValidModelName3 = "Modelo3";
        private List<UsedModel> ValidModelList2;
        private Vector LookAtScene2 = new Vector(0, 1, -2);
        private Vector LookFromScene2 = new Vector(4, 2, 8);

        private Renderer someRenderer3;
        private const string ValidName3 = "Tercera Escena";
        private Scene someScene3;
        private const string ValidMetalName = "Meta";
        private RGBVector ValidColor4 = new RGBVector(0.8, 0.3, 0.6);
        private const double ValidRoughness = 0.2;
        private Metallic ValidMaterial4 = new Metallic
        {
            Name = ValidMetalName,
        };
        private const string ValidMetalName2 = "Meta2";
        private RGBVector ValidColor5 = new RGBVector(0.8, 0.25, 0.05);
        private const double ValidRoughness2 = 0.1;
        private Metallic ValidMaterial5 = new Metallic
        {
            Name = ValidMetalName2,
        };
        private UsedModel someUsedModel4;
        private UsedModel someUsedModel5;
        private Model someModel4;
        private Model someModel5;
        private const string ValidModelName4 = "Modelo4";
        private const string ValidModelName5 = "Modelo5";
        private List<UsedModel> ValidModelList3;

        [TestInitialize]
        public void TestInit()
        {
            ValidShape.Owner = ValidUser;
            ValidShape2.Owner = ValidUser;
            ValidShape3.Owner = ValidUser;

            ValidMaterial.Owner = ValidUser;
            ValidMaterial.Color = ValidColor;
            ValidMaterial2.Owner = ValidUser;
            ValidMaterial2.Color = ValidColor2;
            ValidMaterial3.Owner = ValidUser;
            ValidMaterial3.Color = ValidColor3;
            ValidMaterial4.Owner = ValidUser;
            ValidMaterial4.Color = ValidColor4;
            ValidMaterial4.Roughness = ValidRoughness;
            ValidMaterial5.Owner = ValidUser;
            ValidMaterial5.Color = ValidColor5;
            ValidMaterial4.Roughness = ValidRoughness2;

            someModel = new Model()
            {
                Owner = ValidUser,
                Name = ValidModelName,
                ModelShape = ValidShape,
                ModelMaterial = ValidMaterial,
                Preview = ValidPreview,
            };

            someModel1 = new Model()
            {
                Owner = ValidUser,
                Name = ValidModelName1,
                ModelShape = ValidShape,
                ModelMaterial = ValidMaterial,
                Preview = ValidPreview,
            };

            someModel2 = new Model()
            {
                Owner = ValidUser,
                Name = ValidModelName2,
                ModelShape = ValidShape2,
                ModelMaterial = ValidMaterial2,
                Preview = ValidPreview,
            };

            someModel3 = new Model()
            {
                Owner = ValidUser,
                Name = ValidModelName3,
                ModelShape = ValidShape3,
                ModelMaterial = ValidMaterial3,
                Preview = ValidPreview,
            };

            someModel4 = new Model()
            {
                Owner = ValidUser,
                Name = ValidModelName4,
                ModelShape = ValidShape,
                ModelMaterial = ValidMaterial4,
                Preview = ValidPreview,
            };

            someModel5 = new Model()
            {
                Owner = ValidUser,
                Name = ValidModelName5,
                ModelShape = ValidShape2,
                ModelMaterial = ValidMaterial5,
                Preview = ValidPreview,
            };

            someUsedModel = new UsedModel()
            {
                SelectedModel = someModel,
                Place = ValidPlace
            };

            someUsedModel1 = new UsedModel()
            {
                SelectedModel = someModel1,
                Place = ValidPlace1
            };

            someUsedModel2 = new UsedModel()
            {
                SelectedModel = someModel2,
                Place = ValidPlace2
            };

            someUsedModel3 = new UsedModel()
            {
                SelectedModel = someModel3,
                Place = ValidPlace3
            };

            someUsedModel4 = new UsedModel()
            {
                SelectedModel = someModel4,
                Place = ValidPlace1
            };

            someUsedModel5 = new UsedModel()
            {
                SelectedModel = someModel5,
                Place = ValidPlace2
            };

            ValidModelList = new List<UsedModel>() { someUsedModel };

            ValidModelList2 = new List<UsedModel>() { someUsedModel1, someUsedModel2, someUsedModel3 };

            ValidModelList3 = new List<UsedModel>() { someUsedModel3, someUsedModel4, someUsedModel5 };

            someScene = new Scene()
            {
                Owner = ValidUser,
                Name = ValidName,
                Models = ValidModelList,
                Render = "null",
                Preview = ValidPreview,
            };

            someScene2 = new Scene()
            {
                LookAt = LookAtScene2,
                LookFrom = LookFromScene2,
                Owner = ValidUser,
                Name = ValidName2,
                Models = ValidModelList2,
                Render = "null",
                Preview = ValidPreview,
                Aperture = 3,
                Blurred = true
            };

            someScene3 = new Scene()
            {
                LookAt = LookAtScene2,
                LookFrom = LookFromScene2,
                Owner = ValidUser,
                Name = ValidName3,
                Models = ValidModelList3,
                Render = "null",
                Preview = ValidPreview,
                Blurred = false
            };


            someRenderer = new Renderer(ValidResX, ValidResY, ValidUp, someScene);
            
            someRenderer2 = new Renderer(ValidResX, ValidResY, ValidUp, someScene2);

            someRenderer3 = new Renderer(ValidResX, ValidResY, ValidUp, someScene3);
        }

        [TestMethod]
        public void CreateRendererSuccessTest()
        {

            var renderer = new Renderer(ValidResX, ValidResY, ValidUp, someScene);

            Assert.IsNotNull(renderer);
            Assert.IsNotNull(renderer.ResolutionX);
            Assert.IsNotNull(renderer.ResolutionY);
            Assert.IsNotNull(renderer.Up);
            Assert.IsNotNull(renderer.Scene);
            Assert.AreEqual(ValidResX, renderer.ResolutionX);
            Assert.AreEqual(ValidResY, renderer.ResolutionY);
            Assert.AreEqual(ValidUp, renderer.Up);
            Assert.AreEqual(someScene, renderer.Scene);
        }

        [TestMethod]
        public void RenderRendererSuccessTest()
        {
            var someDouble = 0.5;
            RandomNumberProvider.RandomGenerator = someDouble;
            Assert.AreEqual(someRenderer.Render(), "P3\n10 10\n255\n177 208 255\n177 208 255\n176 208 255\n176 208 255\n176 208 255\n176 208 255\n176 208 255\n176 208 255\n177 208 255\n177 208 255\n180 210 255\n180 210 255\n180 210 255\n180 210 255\n180 210 255\n180 210 255\n180 210 255\n180 210 255\n180 210 255\n180 210 255\n183 212 255\n183 212 255\n183 212 255\n183 212 255\n183 212 255\n183 212 255\n183 212 255\n183 212 255\n183 212 255\n183 212 255\n186 214 255\n186 214 255\n186 214 255\n186 214 255\n14 38 128\n14 38 128\n186 214 255\n186 214 255\n186 214 255\n186 214 255\n190 216 255\n190 216 255\n190 216 255\n18 41 128\n18 41 128\n18 41 128\n18 41 128\n190 216 255\n190 216 255\n190 216 255\n193 218 255\n193 218 255\n193 218 255\n21 45 128\n21 45 128\n21 45 128\n21 45 128\n193 218 255\n193 218 255\n193 218 255\n196 220 255\n196 220 255\n196 220 255\n196 220 255\n24 49 128\n24 49 128\n196 220 255\n196 220 255\n196 220 255\n196 220 255\n199 222 255\n200 222 255\n200 222 255\n200 222 255\n200 222 255\n200 222 255\n200 222 255\n200 222 255\n200 222 255\n199 222 255\n203 224 255\n203 224 255\n203 224 255\n203 224 255\n203 224 255\n203 224 255\n203 224 255\n203 224 255\n203 224 255\n203 224 255\n206 225 255\n206 226 255\n206 226 255\n206 226 255\n206 226 255\n206 226 255\n206 226 255\n206 226 255\n206 226 255\n206 225 255\n");
        }

        [TestMethod]
        public void RenderBlurredScene()
        {
            var someDouble = 0.5;
            RandomNumberProvider.RandomGenerator = someDouble;
            Assert.AreEqual(someRenderer2.Render(), "P3\n10 10\n255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n186 213 255\n185 213 255\n185 213 255\n185 213 255\n185 213 255\n185 213 255\n111 46 13\n112 46 13\n185 213 255\n186 213 255\n189 215 255\n189 215 255\n189 215 255\n189 215 255\n189 215 255\n135 51 13\n136 51 13\n136 51 13\n135 51 13\n189 215 255\n192 217 255\n192 217 255\n192 217 255\n192 217 255\n192 217 255\n82 31 8\n82 31 8\n82 31 8\n82 31 8\n192 217 255\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n82 31 8\n82 31 8\n82 31 8\n82 31 8\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n16 40 128\n16 40 128\n65 22 5\n65 22 5\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n10 25 77\n10 25 77\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n");
        }

        [TestMethod]
        public void RenderMetallicModelInScene()
        {
            var someDouble = 0.5;
            RandomNumberProvider.RandomGenerator = someDouble;
            Assert.AreEqual(someRenderer3.Render(), "P3\n10 10\n255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n182 211 255\n186 213 255\n185 213 255\n185 213 255\n185 213 255\n185 213 255\n185 213 255\n113 47 13\n109 46 13\n185 213 255\n186 213 255\n189 215 255\n189 215 255\n189 215 255\n189 215 255\n189 215 255\n132 50 13\n120 48 13\n120 48 13\n129 50 13\n189 215 255\n192 217 255\n192 217 255\n192 217 255\n192 217 255\n192 217 255\n82 31 8\n82 31 8\n82 31 8\n82 31 8\n192 217 255\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n82 31 8\n68 8 0\n67 8 0\n82 31 8\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n124 58 153\n124 58 153\n89 32 8\n98 34 8\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n90 13 55\n90 13 55\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n102 125 153\n");
        }
    }
}