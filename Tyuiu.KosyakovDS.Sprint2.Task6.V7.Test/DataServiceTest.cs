using Microsoft.Playwright;
using Tyuiu.KosyakovDS.Sprint2.Task6.V7.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int startYear = 1990;
            int n = 55;

            var wait = ds.FindMonthName(startYear, n);
            var res = "Август";

            Assert.AreEqual(wait, res);
        }
    }
}
