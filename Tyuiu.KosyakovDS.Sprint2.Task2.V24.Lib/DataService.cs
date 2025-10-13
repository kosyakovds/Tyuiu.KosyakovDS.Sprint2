using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosyakovDS.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool square = (x >= 3 && x <= 12) && (y >= 3 && y <= 11);
            bool notsq1 = (x >= 3 && x <= 5) && (y >= 8 && y <= 10);
            bool notsq2 = (x >= 6 && x <= 8) && (y >= 3 && y <= 4);
            bool notsq3 = (x >= 8 && x <= 10) && (y == 11);
            bool points = ((x == 7 || x == 11 || x == 12) && y == 12) || (x == 13 && y == 6);
            if ((square && !notsq1 && !notsq2 && !notsq3) || points)
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
