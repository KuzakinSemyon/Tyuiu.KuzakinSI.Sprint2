using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint2.Task0.V26.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1045;
            int y = 975;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[] { false, false, false, true, true, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}