using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y = 0;

            double x2 = Math.Pow(x,2);
            if (x > 1) 
            { 
                y = x * Math.Pow(((x + 9) / (x - 1)),x); 
            }
            else
            { 
                if (x == 0) 
                { 
                    y = (x2 + 10) / (x2 - Math.Sin(x2) + 12);
                }
                else
                {
                     if (x > -25 && x < 2) 
                     {
                        y = Math.Pow(1 + 1/x2,x); 
                     }
                     else
                     {
                        if (x < -25) 
                        { 
                            y = x + 10 * x - 1 / x; 
                        }
                     }
                }
            }

            return Math.Round(y, 3);
        }
    }
}
