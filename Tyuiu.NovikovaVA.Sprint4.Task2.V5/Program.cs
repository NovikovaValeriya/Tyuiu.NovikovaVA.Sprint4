using System.Security.Cryptography;
using Tyuiu.NovikovaVA.Sprint4.Task2.V5.Lib;
namespace Tyuiu.NovikovaVA.Sprint4.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Новикова В.А. | ИСТН-б-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Новикова Валерия Александрован | ИСТН-б-24-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 3 до 9 подсчитать произведение                *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                array[i] = rnd.Next(3, 9);
            }
            Console.WriteLine("Массив:");
            for (int i = 0;i <= len - 1; i++)
            {
                Console.WriteLine(array[i]+"\t");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("произведение всех чётных = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
