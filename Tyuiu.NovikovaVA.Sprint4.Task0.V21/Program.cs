using Tyuiu.NovikovaVA.Sprint4.Task0.V21.Lib;
namespace Tyuiu.NovikovaVA.Sprint4.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Новикова В.А. | ИСТН-б-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Новикова Валерия Александрован | ИСТН-б-24-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива.  {8, 2, 4, 3, 8, 5, 6, 7, 9, 8}                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] array = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= array.Length-1; i++)
            {
                Console.WriteLine(array[i]+" ");
                
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результирующий массив:");
            
            Console.WriteLine("Сумма всех чётных = "+ds.GetSumEvenArrEl(array));
            Console.ReadKey();
        }
    }
}
