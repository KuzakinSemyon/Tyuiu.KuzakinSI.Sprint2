using System;
using Tyuiu.KuzakinSI.Sprint2.Task6.V4.Lib;

namespace Tyuiu.KuzakinSI.Sprint2.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма оператора switch                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Условие: Мастям игральных карт условно присвоены следующие порядковые   *");
            Console.WriteLine("* номера: масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,        *");
            Console.WriteLine("* масти «червы» — 4. По заданному номеру масти m (1 <= m <= 4) определить *");
            Console.WriteLine("* название соответствующей масти.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.Write("Введите номер масти m (1-4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            string result = ds.FindCardSuit(m);
            
            if (m >= 1 && m <= 4)
            {
                Console.WriteLine($"Масть с номером {m} — это {result}");
            }
            else
            {
                Console.WriteLine($"Ошибка: {result}");
                Console.WriteLine("Допустимые значения: 1-4 (1-пики, 2-трефы, 3-бубны, 4-червы)");
            }
            
            Console.ReadLine();
        }
    }
}