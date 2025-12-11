using Tyuiu.NazarovSV.Sprint6.Task2.V20.Lib;
namespace Tyuiu.NazarovSV.Sprint6.Task2.V20.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int start = -5;
            int end = 5;
            double[] res = ds.GetMassFunction(start, end);
            Console.WriteLine(res);
        }
    }
}
