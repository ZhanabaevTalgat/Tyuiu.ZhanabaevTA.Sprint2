using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // (False, False, True, False, True, False) ; ==, !=, <, >, <=, >=
            bool[] res = new bool[6];

            res[0] = (a >= b) | (c > d);
            res[1] = (a == b) & (c < d);
            res[2] = (a != b) || (c + 304 == d);
            res[3] = (a > b) && (c < d);
            res[4] = (a != b)!;
            res[5] = (a == b) ^ (c >= d);

            return res;
        }
    }
}
