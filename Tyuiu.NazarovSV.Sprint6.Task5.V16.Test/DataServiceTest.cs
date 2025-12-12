using Tyuiu.NazarovSV.Sprint6.Task5.V16.Lib;
namespace Tyuiu.NazarovSV.Sprint6.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V16.txt");
            DataService dataServcie = new DataService();
            bool FileStatus = File.Exists(path);
            Assert.IsTrue(FileStatus);
        }
    }
}
