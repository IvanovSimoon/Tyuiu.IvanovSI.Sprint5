using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint5.Task5.V26.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint5.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #5                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V0.txt в котором есть          *");
            Console.WriteLine("* вещественное значение. Найти разницу между суммой всех положительных     *");
            Console.WriteLine("* и отрицательных вещественных чисел в файле. Результат округлить до 3     *");
            Console.WriteLine("* знаков после запятой.                                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask5V26.txt";
            Console.WriteLine("Данные в файле: " + path);

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Разница сумм = " + res);
            Console.ReadKey();
        }
    }
}
