using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint2.Task3.V9.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXGreaterThanZero()
        {
            DataService ds = new DataService();
            
            Assert.AreEqual(2.333, ds.Calculate(22));
            Assert.AreEqual(-2.0, ds.Calculate(1));
            Assert.AreEqual(1.8, ds.Calculate(10));
        }

        [TestMethod]
        public void ValidCalculateXEqualToZero()
        {
            DataService ds = new DataService();
            
            Assert.AreEqual(1.0, ds.Calculate(0));
        }

        [TestMethod]
        public void ValidCalculateXBetweenMinus13AndZero()
        {
            DataService ds = new DataService();
            
            Assert.AreEqual(1.061, ds.Calculate(-1));
            Assert.AreEqual(1.009, ds.Calculate(-5));
            Assert.AreEqual(1.023, ds.Calculate(-10));
        }

        [TestMethod]
        public void ValidCalculateXLessThanMinus13()
        {
            DataService ds = new DataService();
            
            Assert.AreEqual(-154.071, ds.Calculate(-15));
            Assert.AreEqual(-204.05, ds.Calculate(-20));
            Assert.AreEqual(-1004.01, ds.Calculate(-100));
        }
    }
}