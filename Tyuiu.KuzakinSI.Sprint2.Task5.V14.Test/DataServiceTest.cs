using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint2.Task5.V14.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayNameMondayFirst()
        {
            DataService ds = new DataService();
            
            // 1 января - понедельник (d=1)
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));   // 1 января
            Assert.AreEqual("Вторник", ds.FindDayName(2, 1));       // 2 января
            Assert.AreEqual("Среда", ds.FindDayName(3, 1));         // 3 января
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));   // 7 января
            Assert.AreEqual("Понедельник", ds.FindDayName(8, 1));   // 8 января
        }

        [TestMethod]
        public void ValidFindDayNameThursdayFirst()
        {
            DataService ds = new DataService();
            
            // 1 января - четверг (d=4)
            Assert.AreEqual("Четверг", ds.FindDayName(1, 4));       // 1 января
            Assert.AreEqual("Пятница", ds.FindDayName(2, 4));       // 2 января
            Assert.AreEqual("Суббота", ds.FindDayName(3, 4));       // 3 января
            Assert.AreEqual("Воскресенье", ds.FindDayName(4, 4));   // 4 января
            Assert.AreEqual("Понедельник", ds.FindDayName(5, 4));   // 5 января
        }

        [TestMethod]
        public void ValidFindDayNameSundayFirst()
        {
            DataService ds = new DataService();
            
            // 1 января - воскресенье (d=7)
            Assert.AreEqual("Воскресенье", ds.FindDayName(1, 7));   // 1 января
            Assert.AreEqual("Понедельник", ds.FindDayName(2, 7));   // 2 января
            Assert.AreEqual("Вторник", ds.FindDayName(3, 7));       // 3 января
            Assert.AreEqual("Суббота", ds.FindDayName(7, 7));       // 7 января
        }

        [TestMethod]
        public void ValidFindDayNameRandomDays()
        {
            DataService ds = new DataService();
            
            // 1 января - вторник (d=2)
            Assert.AreEqual("Среда", ds.FindDayName(100, 2));       // 100-й день года
            Assert.AreEqual("Пятница", ds.FindDayName(365, 2));     // 365-й день года
        }
    }
}