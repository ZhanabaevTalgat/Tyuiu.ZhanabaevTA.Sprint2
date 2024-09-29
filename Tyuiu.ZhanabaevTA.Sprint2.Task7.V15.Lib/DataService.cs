using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (Math.Pow(x,2) + Math.Pow(y,2) <= 4 && Math.Pow(x, 2) + Math.Pow(y, 2) > 1 && y >= 0)
            {
                res = true;
            }
            else
            {
                 res = false;
            }

            return res;
        }
    }
}
