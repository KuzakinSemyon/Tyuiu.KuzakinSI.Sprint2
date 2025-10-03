using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KuzakinSI.Sprint2.Task0.V26.Lib
{
    public class DataService : ISprint2Task0V26
    {
        public Boolean[] GetCompareOperations(int x, int y)
        {
            return new Boolean[]
            {
                x == y,
                x != y, 
                x < y,
                x > y,
                x <= y,
                x >= y
            };
        }
    }
}