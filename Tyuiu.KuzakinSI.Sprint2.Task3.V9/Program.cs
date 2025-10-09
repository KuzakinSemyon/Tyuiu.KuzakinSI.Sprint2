using System;
using Tyuiu.KuzakinSI.Sprint2.Task4.V9.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
            Console.WriteLine("* переменных x,y с клавиатуры. Если x + 5 < y / 2, то z = (7 + 1/x²)ʸ     *");
            Console.WriteLine("* иначе z = x⁴ - (3/y). Ответ округлите до 3 знаков после запятой.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            double result = ds.Calculate(x, y);
            double roundedResult = Math.Round(result, 3);
            
            Console.WriteLine($"При x = {x}, y = {y}:");
            Console.WriteLine($"Условие (x + 5 < y / 2): {x + 5} < {y / 2} = {x + 5 < y / 2}");
            Console.WriteLine($"Результат z = {roundedResult}");
            
            Console.ReadLine();
        }
    }
}