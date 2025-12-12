using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NazarovSV.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] readFromFile = File.ReadAllLines(path);
            List<double> data = new List<double>();
            foreach (string line in readFromFile)
            {
                if (double.TryParse(line, out double number))
                {
                    if (number > 0)
                    {
                        data.Add(number);

                    }
                }
            }
            double[] res = data.ToArray();
            return res;
        }
    }
}
