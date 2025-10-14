using Tyuiu.KosyakovDS.Sprint2.Task4.V25.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            var wait = 3.375;

            Assert.AreEqual(wait, res);
        }
    }
}
