using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KuzakinSI.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Область "галочка": над параболой y = x² - 2 
            // И (под прямой y = -x ИЛИ под прямой y = x)
            bool aboveParabola = y >= x * x - 2;
            bool underLine1 = y <= -x;
            bool underLine2 = y <= x;
            
            return aboveParabola && (underLine1 || underLine2);
        }
    }
}