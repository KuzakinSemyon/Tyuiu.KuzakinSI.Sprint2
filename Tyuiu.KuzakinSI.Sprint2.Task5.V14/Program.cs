using System;
using Tyuiu.KuzakinSI.Sprint2.Task5.V14.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким днем     *");
            Console.WriteLine("* недели является k-й день не високосного года, в котором 1 января d-й   *");
            Console.WriteLine("* день недели (если 1 января — понедельник, то d=1, если вторник — d=2,  *");
            Console.WriteLine("* ..., если воскресенье — d=7).                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.Write("Введите номер дня в году k (1-365): ");
            int k = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите день недели 1 января d (1-7, где 1-понедельник, 7-воскресенье): ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            if (k < 1 || k > 365 || d < 1 || d > 7)
            {
                Console.WriteLine("Введены неверные данные! k должен быть от 1 до 365, d от 1 до 7.");
            }
            else
            {
                string result = ds.FindDayName(k, d);
                Console.WriteLine($"{k}-й день года является {result}");
            }
            
            Console.ReadLine();
        }
    }
}