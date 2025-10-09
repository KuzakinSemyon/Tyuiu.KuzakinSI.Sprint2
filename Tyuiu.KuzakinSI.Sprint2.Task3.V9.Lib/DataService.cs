using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KuzakinSI.Sprint2.Task3.V9.Lib
{
    public class DataService : ISprint2Task3V9
    {
        public double Calculate(double x)
        {
            double y;
            
            if (x > 0)
            {
                // y = (x + 15) / (x - 7), при x > 0
                y = (x + 15) / (x - 7);
            }
            else if (x == 0)
            {
                // y = (sin x + cos x) / (cos x - sin x), при x = 0
                y = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x));
            }
            else if (-13 < x && x < 0)
            {
                // y = (1 + 4/x²)ˣ, при -13 < x < 0
                y = Math.Pow(1 + 4 / (x * x), x);
            }
            else // x < -13
            {
                // y = x + 10x + (1/x), при x < -13
                y = x + 10 * x + (1 / x);
            }
            
            return Math.Round(y, 3);
        }
    }
}