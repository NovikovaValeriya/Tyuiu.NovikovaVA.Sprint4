using Tyuiu.NovikovaVA.Sprint4.Task6.V22.Lib;
namespace Tyuiu.NovikovaVA.Sprint4.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] things =  { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            string[] res = ds.Calculate(things);
            string[] wait = { "Снег", "Град", "Туча" };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}