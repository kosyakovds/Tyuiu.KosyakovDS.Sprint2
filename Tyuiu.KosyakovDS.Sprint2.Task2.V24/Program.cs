using Tyuiu.KosyakovDS.Sprint2.Task2.V24.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил Косяков Д. С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Косяков Дмитрий Сергеевич | ИИПб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                       *");
            Console.WriteLine("* в заштрихованной области                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 4, y = 5                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x:");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = Int32.Parse(Console.ReadLine());

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