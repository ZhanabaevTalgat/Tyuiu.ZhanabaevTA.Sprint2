using Tyuiu.ZhanabaevTA.Sprint2.Task4.V5.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = -4;
            double res = ds.Calculate(x, y);
            double await = -500;
            Assert.AreEqual(await, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2, y = 4;
            double res = ds.Calculate(x, y);
            double await = 24.25;
            Assert.AreEqual(await, res);
        }
    }
}