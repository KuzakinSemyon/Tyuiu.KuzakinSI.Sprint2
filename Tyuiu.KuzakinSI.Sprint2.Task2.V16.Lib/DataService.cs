using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KuzakinSI.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool inLeftBlock = (x >= 3 && x <= 7) && (y >= 3 && y <= 10);
            bool inRightBlock = (x >= 12 && x <= 14) && (y >= 3 && y <= 8);
            bool inBottomBlock = (x >= 3 && x <= 7) && (y >= 11 && y <= 13);
            bool inMiddleConnector = (x >= 6 && x <= 10) && (y >= 6 && y <= 9);

            return inLeftBlock || inRightBlock || inBottomBlock || inMiddleConnector;
        }
    }
}