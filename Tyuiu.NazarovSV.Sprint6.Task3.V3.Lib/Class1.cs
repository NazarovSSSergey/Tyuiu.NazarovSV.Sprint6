using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NazarovSV.Sprint6.Task3.V3.Lib
{
    public class Class1 : ISprint6Task3V3
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] matrixFunc = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   
                    matrixFunc[i, j] = matrix[i, j];
                }
            }

            for (int j = 0; j < matrixFunc.GetLength(1); j++)
            {
                if (matrixFunc[0, j] % 2 == 0) 
                {
                    matrixFunc[1, j] = 0; 
                }
            }

            return matrixFunc;
        }
    }
}
