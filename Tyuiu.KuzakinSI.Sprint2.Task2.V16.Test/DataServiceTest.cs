using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint2.Task2.V16.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            
            Assert.AreEqual(true, ds.CheckDotInShadedArea(3, 3));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(7, 5));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(12, 4));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(5, 12));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(8, 8));
            
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(8, 2));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(15, 15));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(10, 10));
        }
    }
}