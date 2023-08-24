using Domain;
using Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tests
{
    [TestClass]
    public class RenderLogicTests
    {
        RenderLogic someRenderLogic;

        private const string ValidSceneName = "Scene1";
        private const string ValidScenePreview = "null";
        private Renderer someRenderer;
        private Vector ValidUpVector = new Vector(0, 1, 0);
        private Scene someScene;

        [TestInitialize]
        public void TestInit()
        {
            someRenderLogic = new RenderLogic();
            someScene = new Scene()
            {
                Name = ValidSceneName,
                Preview = ValidScenePreview,
            };
            someRenderer = new Renderer(3, 3, ValidUpVector, someScene);
        }

        [TestMethod]
        public void ShowImageGeneratesACorrectBitmap()
        {
            var b = new Bitmap(3, 3);
            b.SetPixel(0, 0, Color.FromArgb(180, 210, 255));
            b.SetPixel(0, 1, Color.FromArgb(180, 210, 255));
            b.SetPixel(0, 2, Color.FromArgb(180, 210, 255));
            b.SetPixel(1, 0, Color.FromArgb(191, 217, 255));
            b.SetPixel(1, 1, Color.FromArgb(19, 43, 128));
            b.SetPixel(1, 2, Color.FromArgb(191, 217, 255));
            b.SetPixel(2, 0, Color.FromArgb(202, 223, 255));
            b.SetPixel(2, 1, Color.FromArgb(202, 223, 255));
            b.SetPixel(2, 2, Color.FromArgb(202, 223, 255));
            var image = "180 210 255\n180 210 255\n180 210 255\n191 217 255\n19 43 128\n191 217 255\n202 223 255\n202 223 255\n202 223 255";
            Assert.AreEqual(someRenderLogic.ShowImage(image).ToString(), b.ToString());
        }

        [TestMethod]
        public void SetSceneRenderCorrectly()
        {
            RandomNumberProvider.RandomGenerator = 0.5;
            someRenderLogic.SetSceneRenderer(someRenderer, someScene);
            Assert.AreEqual(someScene.Render, "P3\n3 3\n255\n180 210 255\n180 210 255\n180 210 255\n191 217 255\n191 217 255\n191 217 255\n202 223 255\n202 223 255\n202 223 255\n");
        }

        [TestMethod]
        public void SetScenePreviewCorrectly()
        {
            RandomNumberProvider.RandomGenerator = 0.5;
            someRenderLogic.SetScenePreview(someRenderer, someScene);
            Assert.AreEqual(someScene.Preview, "P3\n3 3\n255\n180 210 255\n180 210 255\n180 210 255\n191 217 255\n191 217 255\n191 217 255\n202 223 255\n202 223 255\n202 223 255\n");
        }

        [TestMethod]
        public void GivenValidRendererDTOCreatesRenderer()
        {
            int validResolution = 60;
            var dto = new RendererDTO(validResolution, validResolution, ValidUpVector, someScene);
            var result = someRenderLogic.CreateRenderer(dto);
            Assert.IsNotNull(result);
        }
    }
}
