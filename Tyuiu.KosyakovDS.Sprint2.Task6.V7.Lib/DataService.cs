﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosyakovDS.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            switch (n % 12)
            {
                case 0: return "январь";
                case 1: return "февраль";
                case 2: return "март";
                case 3: return "апрель";
                case 4: return "май";
                case 5: return "июнь";
                case 6: return "июль";
                case 7: return "август";
                case 8: return "сентябрь";
                case 9: return "октябрь";
                case 10: return "ноябрь";
                case 11: return "декабрь";
                default:
                    throw new ArgumentException("Вы ввели не число");
            }
        }
    }
}
