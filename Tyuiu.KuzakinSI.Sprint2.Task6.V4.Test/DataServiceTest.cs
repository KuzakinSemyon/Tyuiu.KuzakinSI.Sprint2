using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint2.Task6.V4.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuitSpades()
        {
            DataService ds = new DataService();
            Assert.AreEqual("пики", ds.FindCardSuit(1));
        }

        [TestMethod]
        public void ValidFindCardSuitClubs()
        {
            DataService ds = new DataService();
            Assert.AreEqual("трефы", ds.FindCardSuit(2));
        }

        [TestMethod]
        public void ValidFindCardSuitDiamonds()
        {
            DataService ds = new DataService();
            Assert.AreEqual("бубны", ds.FindCardSuit(3));
        }

        [TestMethod]
        public void ValidFindCardSuitHearts()
        {
            DataService ds = new DataService();
            Assert.AreEqual("червы", ds.FindCardSuit(4));
        }

        [TestMethod]
        public void ValidFindCardSuitInvalidValue()
        {
            DataService ds = new DataService();
            Assert.AreEqual("недопустимое значение", ds.FindCardSuit(0));
            Assert.AreEqual("недопустимое значение", ds.FindCardSuit(5));
            Assert.AreEqual("недопустимое значение", ds.FindCardSuit(-1));
        }
    }
}