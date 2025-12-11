using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NazarovSV.Sprint6.Task3.V3.Lib
{
    public class Class1 : ISprint6Task3V3
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows - 1; i++)
            {
                int minIn = i;
                for (int j = i + 1; j < rows; j++)
                {
                    if (matrix[j, 5] < matrix[minIn, 5])
                    {
                        minIn = j;
                    }
                }
                int temp = matrix[i, 5];
                matrix[i, 5] = matrix[minIn, 5];
                matrix[minIn, 5] = temp;
            }
            return matrix;
        }
    }
}
