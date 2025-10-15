using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosyakovDS.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            int m = value1;
            int k = value2;
            string a = "";
            string b = "";
            switch (m)
            {
                case 1:
                    a = "пик";
                    break;
                case 2:
                    a = "треф";
                    break;
                case 3:
                    a = "бубey";
                    break;
                case 4:
                    a = "черв";
                    break;
                default:
                    throw new ArgumentException("1 <= m <= 4");
            }
            switch (k)
            {
                case 6:
                    b = "шестерка";
                    break;
                case 7:
                    b = "семерка";
                    break;
                case 8:
                    b = "восьмерка";
                    break;
                case 9:
                    b = "девятка";
                    break;
                case 10:
                    b = "десятка";
                    break;
                case 11:
                    b = "валет";
                    break;
                case 12:
                    b = "дама";
                    break;
                case 13:
                    b = "король";
                    break;
                case 14:
                    b = "тузь";
                    break;
                default:
                    throw new ArgumentException("10 <= k <= 14");
            }
            return b + " " + a;

        }
    }
}
