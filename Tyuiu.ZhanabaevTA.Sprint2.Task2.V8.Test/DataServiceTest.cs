using Tyuiu.ZhanabaevTA.Sprint2.Task2.V8.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            int x = 6; int y = 7;
            
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            bool await = true;

            Assert.AreEqual(await, res);
        }
    }
}