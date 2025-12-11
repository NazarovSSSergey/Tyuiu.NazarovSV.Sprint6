using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NazarovSV.Sprint6.Task3.V3.Lib
{
    public class Class1 : ISprint6Task3V3
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] matrixFunc = new int[5, 5]
            {
                {-18, -15, 10, -2, 12},
                {-18, -10, 33, -20, 32},
                {14, -9, -14, 12, -18},
                {-19, 5, -3, 28, -17},
                {-14, 21, 23, -13, 11}
            };

           
            return matrixFunc;
        }
    }
}
