using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NazarovSV.Sprint6.Task4.V20.Lib
{
    public class DataService : ISprint6Task4V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double f;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                f = ((Math.Sin(x) - 2 * x ) / (3 * x - 1)) + Math.Sin(x) - 3 * x + 2;
                f = Math.Round(f, 2);
                valueArray[c] = f;
                c++;
            }
            return valueArray;
        }
    }
}
