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
            string[] things =  { "����", "�����", "�����", "����", "�����", "����", "������" };
            string[] res = ds.Calculate(things);
            string[] wait = { "����", "����", "����" };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}