using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class CameraTests
    {
        private Vector ValidLookFrom = new Vector(0, 0, 0);
        private Vector ValidLookAt = new Vector(0, 0, 5);
        private Vector ValidVectorUp = new Vector(0, 1, 1);
        private int ValidFov = 30;
        private int ValidAspectRatio = 45;

        private const int NumberOfDecimals = 4;

        private Camera someCamera;

        [TestInitialize]
        public void TestInit()
        {
            someCamera = new Camera(ValidLookFrom, ValidLookAt, ValidVectorUp, ValidFov, ValidAspectRatio);
        }

        [TestMethod]
        public void CreateCameraSuccessTest()
        {
            var expectedLowerLeftCornerX = 12.0577;
            var expectedLowerLeftCornerY = -0.2679;
            var expectedLowerLeftCornerZ = 1;
            var expectedHorizontalX = -24.1154;
            var expectedVerticalY = 0.5359;
            var expectedValueZero = 0;

            var camera = new Camera(ValidLookFrom, ValidLookAt, ValidVectorUp, ValidFov, ValidAspectRatio);

            Assert.IsNotNull(camera);
            Assert.AreEqual(camera.Origin, ValidLookFrom);
            Assert.AreEqual(Math.Round(camera.LowerLeftCorner.X, NumberOfDecimals), expectedLowerLeftCornerX);
            Assert.AreEqual(Math.Round(camera.LowerLeftCorner.Y, NumberOfDecimals), expectedLowerLeftCornerY);
            Assert.AreEqual(camera.LowerLeftCorner.Z, expectedLowerLeftCornerZ);
            Assert.AreEqual(Math.Round(camera.Horizontal.X, NumberOfDecimals), expectedHorizontalX);
            Assert.AreEqual(camera.Horizontal.Y, expectedValueZero);
            Assert.AreEqual(camera.Horizontal.Z, expectedValueZero);
            Assert.AreEqual(camera.Vertical.X, expectedValueZero);
            Assert.AreEqual(Math.Round(camera.Vertical.Y, NumberOfDecimals), expectedVerticalY);
            Assert.AreEqual(camera.Vertical.Z, expectedValueZero);
        }

        [TestMethod]
        public void GivenValidInputReturnsCorrectRay()
        {
            int ValidU = 7;
            int ValidV = 5;

            var expectedDirectionX = -156.7503;
            var expectedDirectionY = 2.4115;
            var expectedDirectionZ = 1;

            Ray result = someCamera.GetRay(ValidU, ValidV);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Origin, someCamera.Origin);
            Assert.AreEqual(Math.Round(result.Direction.X, NumberOfDecimals), expectedDirectionX); 
            Assert.AreEqual(Math.Round(result.Direction.Y, NumberOfDecimals), expectedDirectionY); 
            Assert.AreEqual(result.Direction.Z, expectedDirectionZ);
        }
    }
}
