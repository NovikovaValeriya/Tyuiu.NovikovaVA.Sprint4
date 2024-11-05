using Tyuiu.NovikovaVA.Sprint4.Task1.V24.Lib;
namespace Tyuiu.NovikovaVA.Sprint4.Task1.V24;

class Program
{
    static void Main(string[] args)
    {
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
        Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 5 подсчитать произведение   *");
        Console.WriteLine("* нечетных элементов массива. С клавиатуры:                               *");
        Console.WriteLine("*  2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int len;
        Console.Write("Введите количество элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[len];
        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("Введите значение"+i+"элемента массива:");
            array[i]= Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("произведение всех нечётных = " + ds.Calculate(array));
        Console.ReadKey();
    }
}
