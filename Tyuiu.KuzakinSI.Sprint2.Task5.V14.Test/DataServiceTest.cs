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
            Assert.AreEqual("понедельник", ds.FindDayName(1, 1));   // 1 января
            Assert.AreEqual("вторник", ds.FindDayName(2, 1));       // 2 января
            Assert.AreEqual("среда", ds.FindDayName(3, 1));         // 3 января
            Assert.AreEqual("воскресенье", ds.FindDayName(7, 1));   // 7 января
            Assert.AreEqual("понедельник", ds.FindDayName(8, 1));   // 8 января
        }

        [TestMethod]
        public void ValidFindDayNameThursdayFirst()
        {
            DataService ds = new DataService();
            
            // 1 января - четверг (d=4)
            Assert.AreEqual("четверг", ds.FindDayName(1, 4));       // 1 января
            Assert.AreEqual("пятница", ds.FindDayName(2, 4));       // 2 января
            Assert.AreEqual("суббота", ds.FindDayName(3, 4));       // 3 января
            Assert.AreEqual("воскресенье", ds.FindDayName(4, 4));   // 4 января
            Assert.AreEqual("понедельник", ds.FindDayName(5, 4));   // 5 января
        }

        [TestMethod]
        public void ValidFindDayNameSundayFirst()
        {
            DataService ds = new DataService();
            
            // 1 января - воскресенье (d=7)
            Assert.AreEqual("воскресенье", ds.FindDayName(1, 7));   // 1 января
            Assert.AreEqual("понедельник", ds.FindDayName(2, 7));   // 2 января
            Assert.AreEqual("вторник", ds.FindDayName(3, 7));       // 3 января
            Assert.AreEqual("суббота", ds.FindDayName(7, 7));       // 7 января
        }

        [TestMethod]
        public void ValidFindDayNameRandomDays()
        {
            DataService ds = new DataService();
            
            // 1 января - вторник (d=2)
            Assert.AreEqual("среда", ds.FindDayName(100, 2));       // 100-й день года
            Assert.AreEqual("пятница", ds.FindDayName(365, 2));     // 365-й день года
        }
    }
}