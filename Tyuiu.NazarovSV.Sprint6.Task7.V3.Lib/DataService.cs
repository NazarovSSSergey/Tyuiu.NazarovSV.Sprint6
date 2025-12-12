using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NazarovSV.Sprint6.Task7.V3.Lib
{
    public class DataService : ISprint6Task7V3
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayalues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayalues[i, j] = Convert.ToInt32(line_i[j]);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayalues[i, 0] % 2 == 0) 
                {
                    arrayalues[i, 0] = -1;
                }
            }

            return arrayalues;
        }
    }
}
