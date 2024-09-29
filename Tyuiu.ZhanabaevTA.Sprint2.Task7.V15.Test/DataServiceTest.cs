using Tyuiu.ZhanabaevTA.Sprint2.Task7.V15.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}