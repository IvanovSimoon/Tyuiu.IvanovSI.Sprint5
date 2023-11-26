using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint5.Task7.V5.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint5.Task7.V5
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
            Console.WriteLine("* Задания #7                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask7V5.txt в котором есть          *");
            Console.WriteLine("* набор символьных данных.Удалить все латинские буквы из файла. Полученный *");
            Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V5.txt.                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask7V5.txt";
            string pathsave = $@"C:\DataSprint5\OutPutDataFileTask7V5.txt";
            Console.WriteLine("Данные в файле: " + path);

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            pathsave = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат находится в файле: " + pathsave);
            Console.ReadKey();
        }
    }
}
