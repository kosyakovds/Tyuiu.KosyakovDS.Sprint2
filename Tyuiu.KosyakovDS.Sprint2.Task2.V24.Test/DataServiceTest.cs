using Tyuiu.KosyakovDS.Sprint2.Task2.V24.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 5;

            var res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
