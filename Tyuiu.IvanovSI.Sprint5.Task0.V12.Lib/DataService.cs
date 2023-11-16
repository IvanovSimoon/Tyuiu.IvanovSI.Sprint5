using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IvanovSI.Sprint5.Task0.V12.Lib
{
    public class DataService : ISprint5Task0V12
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = Math.Pow(x, 3) / (2 * Math.Pow((x + 5), 2));
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
