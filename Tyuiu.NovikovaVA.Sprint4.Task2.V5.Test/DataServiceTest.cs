using Tyuiu.NovikovaVA.Sprint4.Task2.V5.Lib;
namespace Tyuiu.NovikovaVA.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds  = new DataService();
            int[] numsArray = { 1, 2, 3, 4, 5 };
            int res = ds.Calculate(numsArray);
            int wait = 8;
            Assert.AreEqual(res, wait);
        }
    }
}