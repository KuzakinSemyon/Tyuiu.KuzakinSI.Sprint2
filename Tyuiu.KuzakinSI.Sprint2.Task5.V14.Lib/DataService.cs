using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KuzakinSI.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            // Вычисляем номер дня недели для k-го дня
            // (k + d - 2) % 7 + 1: 
            // -2 потому что начинаем с d (1 января), а не с 0
            // +1 чтобы получить диапазон 1-7 вместо 0-6
            int dayOfWeek = (k + d - 2) % 7 + 1;

            string dayName;
            
            switch (dayOfWeek)
            {
                case 1:
                    dayName = "Понедельник";
                    break;
                case 2:
                    dayName = "Вторник";
                    break;
                case 3:
                    dayName = "Среда";
                    break;
                case 4:
                    dayName = "Четверг";
                    break;
                case 5:
                    dayName = "Пятница";
                    break;
                case 6:
                    dayName = "Суббота";
                    break;
                case 7:
                    dayName = "Воскресенье";
                    break;
                default:
                    dayName = "Ошибка";
                    break;
            }

            return dayName;
        }
    }
}