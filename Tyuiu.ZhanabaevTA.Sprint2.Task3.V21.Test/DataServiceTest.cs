using Tyuiu.ZhanabaevTA.Sprint2.Task3.V21.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double await = 242;
            Assert.AreEqual(await, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double await = 0.833;
            Assert.AreEqual(await, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double await = 0.5;
            Assert.AreEqual(await, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double await = -329.967;
            Assert.AreEqual(await, res);
        }
    }
}