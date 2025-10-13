using Tyuiu.KosyakovDS.Sprint2.Task3.V16.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int x = 4;
            var res = Math.Round(ds.Calculate(x), 3);
            var wait = 8.63;

            Assert.AreEqual(res, wait);
        }
    }
}
