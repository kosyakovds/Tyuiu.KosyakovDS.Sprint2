using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosyakovDS.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = a == b | c == d;
            res[1] = a > b & c < d;
            res[2] = b <= c || a == d;
            res[3] = b != c && b < d;
            res[4] = !(a == c);
            res[5] = a > d ^ b < c;

            return res;
        }
    }
}
