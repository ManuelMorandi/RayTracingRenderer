using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class HitRecordTests
    {
        private double ValidT = 10.25;
        private Vector ValidIntersection = new Vector(22.3, 30, 25);
        private Vector ValidNormal = new Vector(20, 20, 20);
        private RGBVector ValidAttenuation = new RGBVector(0.2, 0.2, 0.2);
        private HitRecord someHitRecord;

        [TestInitialize]
        public void TestInit()
        {
            someHitRecord = new HitRecord();
            someHitRecord.T = ValidT;
            someHitRecord.Intersection = ValidIntersection;
            someHitRecord.Normal = ValidNormal;
            someHitRecord.Attenuation = ValidAttenuation;
        }

        [TestMethod]
        public void CreateHitRecordSuccessTest()
        {
            var hitRecord = new HitRecord()
            {
                T = ValidT,
                Intersection = ValidIntersection,
                Normal = ValidNormal,
                Attenuation = ValidAttenuation,
            };

            Assert.IsNotNull(hitRecord);
            Assert.AreEqual(hitRecord.T, ValidT);
            Assert.AreEqual(hitRecord.Intersection, ValidIntersection);
            Assert.AreEqual(hitRecord.Normal, ValidNormal);
            Assert.AreEqual(hitRecord.Attenuation, ValidAttenuation);
        }
    }
}