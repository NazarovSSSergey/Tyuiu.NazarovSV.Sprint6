using Tyuiu.NazarovSV.Sprint6.Task1.V24.Lib;
namespace Tyuiu.NazarovSV.Sprint6.Task1.V24.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueNextArray;
            valueNextArray = new double[len];
            valueNextArray[0] = 5;
            valueNextArray[1] = 5;
            valueNextArray[2] = 5;
            valueNextArray[3] = 5;
            valueNextArray[4] = 5;
            valueNextArray[5] = 5;
            valueNextArray[6] = 5;
            valueNextArray[7] = 5;
            valueNextArray[8] = 5;
            valueNextArray[9] = 5;
            valueNextArray[10] = 5;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueNextArray);
        }
    }
}
