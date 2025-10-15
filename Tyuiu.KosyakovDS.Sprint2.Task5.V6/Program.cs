using Tyuiu.KosyakovDS.Sprint2.Task5.V6.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил Косяков Д. С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Косяков Дмитрий Сергеевич | ИИПб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить полное название соответствующей карты                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* value1 = 3, value2 = 10                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер масти:");
            int value1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства карты:");
            int value2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ваша карта:" + ds.FindCardNameAndValue(value1, value2));
        }
    }
}