using Tyuiu.NovikovaVA.Sprint4.Task1.V24.Lib;
namespace Tyuiu.NovikovaVA.Sprint4.Task1.V24.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalc()
    {
        DataService ds  = new DataService();
        int[] numsArray = { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 };
        int res = ds.Calculate(numsArray);
        int wait = 84375;
        Assert.AreEqual(res, wait);
    }
}