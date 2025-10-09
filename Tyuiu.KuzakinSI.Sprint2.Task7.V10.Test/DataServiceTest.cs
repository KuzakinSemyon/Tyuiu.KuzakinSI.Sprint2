using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint2.Task7.V10.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedAreaInZone()
        {
            DataService ds = new DataService();
            
            // Точки внутри заштрихованной области
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 1));    // Центральная часть
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-1, 0));   // Левая ветвь
            Assert.AreEqual(true, ds.CheckDotInShadedArea(1, 0));    // Правая ветвь
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 2));    // Верхняя часть
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaOnBorder()
        {
            DataService ds = new DataService();
            
            // Точки на границах
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, -2));   // На параболе
            Assert.AreEqual(true, ds.CheckDotInShadedArea(1, -1));   // На прямой y = -x
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-1, -1));  // На прямой y = x
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaOutside()
        {
            DataService ds = new DataService();
            
            // Точки вне заштрихованной области
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, -3));  // Под параболой
            Assert.AreEqual(false, ds.CheckDotInShadedArea(2, 3));   // Над обеими прямыми
            Assert.AreEqual(false, ds.CheckDotInShadedArea(-2, 3));  // Над обеими прямыми
            Assert.AreEqual(false, ds.CheckDotInShadedArea(3, 1));   // Над прямой y = x
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaSpecialCases()
        {
            DataService ds = new DataService();
            
            // Специальные случаи
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.5, -0.5));   // На границе зоны
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.5, 1));     // Над прямой
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-0.5, -0.5));  // На границе зоны
        }
    }
}