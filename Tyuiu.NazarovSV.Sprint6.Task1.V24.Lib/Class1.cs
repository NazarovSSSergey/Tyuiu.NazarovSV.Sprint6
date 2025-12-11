using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NazarovSV.Sprint6.Task1.V24.Lib
{
    public class Class1 : ISprint6Task1V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] ArrayFunc = new double[len];

            int Index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((i + 1.7) == 0)
                {
                    ArrayFunc[Index] = 0;
                }
                else
                {
                    double res = (Math.Sin(i) / i + 1.7) - Math.Cos(i) * 4 * i - 6;
                    ArrayFunc[Index] = Math.Round(res, 2);
                }
                Index++;
            }
            return ArrayFunc;
        }
    }
}
