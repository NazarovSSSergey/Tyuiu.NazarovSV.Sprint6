using Tyuiu.NazarovSV.Sprint6.Task0.V4.Lib;
namespace Tyuiu.NazarovSV.Sprint6.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 68.3;
            Assert.AreEqual(wait, res);
        }
    }
}
