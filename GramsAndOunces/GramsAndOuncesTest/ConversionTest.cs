using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GramsAndOunces;

namespace GramsAndOuncesTest
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void GramToOuncesSimple()
        {
            Assert.AreEqual(0.3527396195, GramsOuncesConversion.GramsToOunces(10), 0.00001);
        }

        [TestMethod]
        public void OuncesToGramsSimple()
        {
            Assert.AreEqual(283.4952, GramsOuncesConversion.OuncesToGrams(10), 0.00001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GramsToOuncesNegative()
        {
            GramsOuncesConversion.GramsToOunces(-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OuncesToGramsNegative()
        {
            GramsOuncesConversion.OuncesToGrams(-10);
        }

        [TestMethod]
        public void GramsToOuncesCheck()
        {
            Assert.AreNotEqual(100, GramsOuncesConversion.GramsToOunces(1), 0.00001);
        }

        [TestMethod]
        public void OuncesToGramsCheck()
        {
            Assert.AreNotEqual(100, GramsOuncesConversion.OuncesToGrams(1), 0.00001);
        }
    }
}
