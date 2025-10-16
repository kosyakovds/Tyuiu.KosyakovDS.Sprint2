﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosyakovDS.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            switch (n % 12)
            {
                case 0: return "Январь";
                case 1: return "Февраль";
                case 2: return "Март";
                case 3: return "Апрель";
                case 4: return "Май";
                case 5: return "Июнь";
                case 6: return "Июль";
                case 7: return "Август";
                case 8: return "Сентябрь";
                case 9: return "Октябрь";
                case 10: return "Ноябрь";
                case 11: return "Декабрь";
                default:
                    throw new ArgumentException("Вы ввели не число");
            }
        }
    }
}
