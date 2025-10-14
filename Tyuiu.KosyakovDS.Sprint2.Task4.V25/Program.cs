using Tyuiu.KosyakovDS.Sprint2.Task4.V25.Lib;

namespace Tyuiu.KosyakovDS.Sprint2.Task4.V25
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Косяков Дмитрий Сергеевич | ИИПб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит          *");
            Console.WriteLine("* значение переменных X, Y с клавиатуры. Округлить полученное значение    *");
            Console.WriteLine("* до трех знаков после запятой                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*               y             ( 2 )^y            (x+1)^x                  *");
            Console.WriteLine("* Если х-20*2 < -, то z = 1 + ( - )  , иначе y + (---)                    *");
            Console.WriteLine("*               4             ( x )              (y+2)                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}