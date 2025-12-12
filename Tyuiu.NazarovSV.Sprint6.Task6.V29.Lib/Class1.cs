using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.NazarovSV.Sprint6.Task6.V29.Lib
{
    public class Class1 : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains("i"))
                        {
                            resStr += word + " ";
                        }
                    }
                }
            }
            return resStr.Trim();
        }
    }
}
