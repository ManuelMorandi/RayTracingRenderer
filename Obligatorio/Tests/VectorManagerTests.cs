using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Controllers;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    
    [TestClass]
    public class VectorManagerTests
    {
        private VectorManager someLogic;

        public VectorManagerTests()
        {
            someLogic = new VectorManager();
        }

        [TestMethod]
        public void GivenValidVectorDTOCreatesRGBVector()
        {
            var validColorValue = 0.25;
            RGBVector expected = new RGBVector(validColorValue, validColorValue, validColorValue);
            var dto = new VectorDTO(validColorValue, validColorValue, validColorValue);
            var result = someLogic.CreateRGBVector(dto);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void GivenValidVectorDTOCreatesVector()
        {
            var validVectorValue = 0.25;
            Vector expected = new Vector(validVectorValue, validVectorValue, validVectorValue);
            var dto = new VectorDTO(validVectorValue, validVectorValue, validVectorValue);
            var result = someLogic.CreateVector(dto);
            Assert.AreEqual(result, expected);
        }
    }
}
