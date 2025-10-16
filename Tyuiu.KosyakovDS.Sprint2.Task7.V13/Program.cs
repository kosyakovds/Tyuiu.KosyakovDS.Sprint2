using Tyuiu.KosyakovDS.Sprint2.Task7.V13.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил Косяков Д. С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Косяков Дмитрий Сергеевич | ИИПб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка                 *");
            Console.WriteLine("* с координатами X,Y в заштрихованной области.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 1, y = 1                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());

            if (ds.CheckDotInShadedArea(x, y))
            {
                Console.WriteLine("Ваша точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Ваша точка не находится в заштрихованной области");
            }

            Console.ReadLine();
        }
    }
}