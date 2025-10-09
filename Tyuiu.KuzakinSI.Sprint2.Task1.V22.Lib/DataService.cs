using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KuzakinSI.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[]
            {
                (a < b) | (c > d),
                (a < b) & (c > d),
                (a < b) || (c > d),
                (a > b) && (c < d),
                !(a < b),
                (a > b) ^ (c < d)
            };
        }
    }
}