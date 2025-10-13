using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosyakovDS.Sprint2.Task3.V16.Lib
{
    public class DataService : ISprint2Task3V16
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return x + Math.Pow(((x + 1) / (x - 1)), 3);
            }
            else
            {
                if (x == 0)
                {
                    return (2 * Math.Pow(x, 2) - Math.Pow(Math.Cos(x), 2) + 10) / (5 * Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 12);
                }
                else
                {
                    if (x > -20 && x < 2)
                    {
                        return Math.Pow(1 + 1 / Math.Pow(x, 2), 7);
                    }
                    else
                    {
                        if (x < -20)
                        {
                            return x + 10 * x - (1 / x);
                        }
                        else
                        {
                            throw new ArgumentException("Данный x находится вне диапазона функции");
                        }
                    }
                }
            }
        }
    }
}
