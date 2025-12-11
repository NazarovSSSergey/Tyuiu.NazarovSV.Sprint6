using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NazarovSV.Sprint6.Task2.V20.Lib
{
    public class Class1 : ISprint6Task2V20
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
                
                if (x == 0)
                {
                    valueArray[c] = 0; 
                }
                else
                {
                    y = (Math.Sin(x) / x + 1.2) - Math.Sin(x) * 2 - 2 * x;
                    valueArray[c] = Math.Round(y, 2) - 1.26;
                }
                c++;
            }
            return valueArray;
        }
    }
}