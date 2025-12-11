using Tyuiu.NazarovSV.Sprint6.Task1.V24.Lib;
namespace Tyuiu.NazarovSV.Sprint6.Task2.V20.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 dataService = new Class1();
            int start = -5;
            int end = 5;
            double[] res = dataService.GetMassFunction(start, end);
            Console.WriteLine(res);
        }
    }
}
