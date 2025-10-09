using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint2.Task1.V22.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[] { true, true, true, false, false, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}