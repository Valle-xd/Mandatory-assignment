using Mandatory_assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GramsIntoOunces()
        {
            Assert.AreEqual(0.70547923899, Converterdll.Grams2Ounces(20), 0.001);
        }

        [TestMethod]
        public void GramsWithDecimalIntoOunces()
        {
            Assert.AreEqual(0.82893810582, Converterdll.Grams2Ounces(23.5), 0.001);
        }

        [TestMethod]
        public void OuncesIntoGrams()
        {
            Assert.AreEqual(708.738, Converterdll.Ounces2Grams(25), 0.001);
        }

        [TestMethod]
        public void OuncesWithDecimalIntoGrams()
        {
            Assert.AreEqual(581.16516, Converterdll.Ounces2Grams(20.5), 0.001);
        }

    }
}
