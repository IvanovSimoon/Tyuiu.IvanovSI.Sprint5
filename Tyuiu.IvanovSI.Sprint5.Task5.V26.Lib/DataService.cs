using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double m = 0;
            double p = 0;
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) < 0)
                    {
                        m += Math.Round(Convert.ToDouble(line),3);
                    }
                    if (Convert.ToDouble(line) > 0)
                    {
                        p += Math.Round(Convert.ToDouble(line), 3);
                    }
                    res = p - m;
                }
            }
            return res;
        }

    }
}
