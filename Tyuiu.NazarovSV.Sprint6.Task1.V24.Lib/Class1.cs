using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NazarovSV.Sprint6.Task1.V24.Lib
{
    public class Class1 : ISprint6Task1V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ( Math.Sin(x) / x + 1.7 ) - Math.Cos(x) * 4 * x - 6;
                if (x + 1.7 == 0)
                {
                    valueArray[c] = 0;
                }
                else
                {
                    valueArray[c] = y;
                }
                c++;
            }
            return valueArray;
        }
    }
}
