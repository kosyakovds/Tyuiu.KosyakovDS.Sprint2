using Tyuiu.KosyakovDS.Sprint2.Task1.V6.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task1.V6
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Косяков Дмитрий Сергеевич | ИИПб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также *");
            Console.WriteLine("* арифметических выражений которая вернет логическую последовательность   *");
            Console.WriteLine("* (массив): (False, False, True, False, True, False)                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" a = 915, b = 169, c = 174, d = 133                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите a:");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите b:");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите c:");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите d:");
            int d = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(ds.GetLogicOperations(a, b, c, d)[i]);
            }

            Console.ReadLine();
        }
    }
}
