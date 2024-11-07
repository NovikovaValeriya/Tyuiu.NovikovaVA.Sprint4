using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NovikovaVA.Sprint4.Task6.V22.Lib
{
    public class DataService : ISprint4Task6V22
    {
        public string[] Calculate(string[] array)
        {
            string[] arr = Array.FindAll(array, i => i.Length == 4);
            return arr;
        }
    }
}
