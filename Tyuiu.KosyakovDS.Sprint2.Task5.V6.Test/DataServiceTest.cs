using Tyuiu.KosyakovDS.Sprint2.Task5.V6.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int value1 = 3;
            int value2 = 10;
            string res = ds.FindCardNameAndValue(value1, value2);

            string wait = "десятка бубны";

            Assert.AreEqual(wait, res);
        }
    }
}
