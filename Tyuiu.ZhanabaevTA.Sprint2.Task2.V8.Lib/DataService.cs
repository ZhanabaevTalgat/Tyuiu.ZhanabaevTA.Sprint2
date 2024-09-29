using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if (x > 2 && x < 6 && y > 2 && y < 8)
            {
                res = true;
            }
            else if (x > 5 && x < 10 && y > 4 && y < 13)
            {
                res = true;
                if ((x > 7 && x < 9 && y > 6 && y < 9) || (x == 6 && y == 12))
                {
                    res = false;
                }
            }
            else if ((y == 11) && (x == 3 || x == 4 || x == 5))
            {
                res = true;
            }
            else if ((x > 8 && x < 12 && y > 1 && y < 5) || (x == 12 && y == 3))
            {
                res = true;
            }
            else if (x > 6 && x < 14 && y > 5 && y < 8)
            {
                res = true;
            }
            else if (x > 8 && x < 14 && y > 7 && y < 10)
            {
                res = true;
            }
            else if (x == 14 && y == 7)
            {
                res = true;
            }

            return res;
        }
    }
}
