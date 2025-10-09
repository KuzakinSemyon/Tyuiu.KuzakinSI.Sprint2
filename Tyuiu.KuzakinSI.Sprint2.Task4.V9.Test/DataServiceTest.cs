using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint2.Task4.V9.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateConditionTrue()
        {
            DataService ds = new DataService();
            
            // x + 5 < y / 2 = true
            double x = 1;
            double y = 20;
            double wait = Math.Pow(7 + 1 / (x * x), y);
            Assert.AreEqual(Math.Round(wait, 3), Math.Round(ds.Calculate(x, y), 3));
        }

        [TestMethod]
        public void ValidCalculateConditionFalse()
        {
            DataService ds = new DataService();
            
            // x + 5 < y / 2 = false
            double x = 5;
            double y = 2;
            double wait = Math.Pow(x, 4) - (3 / y);
            Assert.AreEqual(Math.Round(wait, 3), Math.Round(ds.Calculate(x, y), 3));
        }

        [TestMethod]
        public void ValidCalculateBorderCase()
        {
            DataService ds = new DataService();
            
            // x + 5 = y / 2 (условие false)
            double x = 2;
            double y = 14; // 2 + 5 = 7, 14/2 = 7
            double wait = Math.Pow(x, 4) - (3 / y);
            Assert.AreEqual(Math.Round(wait, 3), Math.Round(ds.Calculate(x, y), 3));
        }
    }
}