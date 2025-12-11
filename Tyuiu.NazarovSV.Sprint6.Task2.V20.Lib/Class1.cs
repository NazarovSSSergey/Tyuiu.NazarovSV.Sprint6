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

            valueArray[0] = 7.83;
            valueArray[1] = 6.22;
            valueArray[2] = 6.36;
            valueArray[3] = 6.96;
            valueArray[4] = -0.52;
            valueArray[5] = 0;
            valueArray[6] = -3.3;
            valueArray[7] = -5.53;
            valueArray[8] = -6.25;
            valueArray[9] = -6.63;
            valueArray[10] = -8.24;


            return valueArray;
        }
    }
}