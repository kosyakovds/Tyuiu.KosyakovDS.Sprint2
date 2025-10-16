using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosyakovDS.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool triangle = (y <= 1) && (y >= x - 1) && (x >= 0);
            bool semicircle = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x >= 0);
            if (triangle || semicircle)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
