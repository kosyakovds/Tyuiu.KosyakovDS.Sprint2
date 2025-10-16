using Tyuiu.KosyakovDS.Sprint2.Task7.V13.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
