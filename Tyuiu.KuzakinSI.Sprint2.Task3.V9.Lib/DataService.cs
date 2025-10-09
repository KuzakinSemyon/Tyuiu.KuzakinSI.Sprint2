using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KuzakinSI.Sprint2.Task4.V9.Lib
{
    public class DataService : ISprint2Task4V9
    {
        public double Calculate(double x, double y)
        {
            return (x + 5 < y / 2) 
                ? Math.Pow(7 + 1 / (x * x), y) 
                : Math.Pow(x, 4) - (3 / y);
        }
    }
}