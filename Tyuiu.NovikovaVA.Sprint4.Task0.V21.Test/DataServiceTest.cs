using Tyuiu.NovikovaVA.Sprint4.Task0.V21.Lib;
namespace Tyuiu.NovikovaVA.Sprint4.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}