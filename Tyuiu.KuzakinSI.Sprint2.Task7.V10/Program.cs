using System;
using Tyuiu.KuzakinSI.Sprint2.Task7.V10.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области. Область задана графиками: парабола       *");
            Console.WriteLine("* y = x² - 2 и прямые y = -x, y = x. Закрашена область над параболой     *");
            Console.WriteLine("* и (под прямой y = -x ИЛИ под прямой y = x).                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            bool result = ds.CheckDotInShadedArea(x, y);
            
            Console.WriteLine($"Точка с координатами ({x},{y}) {(result ? "находится" : "не находится")} в заштрихованной области");
            Console.WriteLine();
            Console.WriteLine("Описание области:");
            Console.WriteLine("- Над параболой: y >= x² - 2");
            Console.WriteLine("- И (под прямой y = -x ИЛИ под прямой y = x)");
            
            Console.ReadLine();
        }
    }
}