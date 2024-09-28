using Tyuiu.ZhanabaevTA.Sprint2.Task0.V3.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();

            int x = 45;
            int y = 127;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            bool[] await = new bool[] { false, true, false, true, false, true };

            CollectionAssert.AreEqual(await, res);

        }
    }
}