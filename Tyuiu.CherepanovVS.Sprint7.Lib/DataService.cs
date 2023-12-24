using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tyuiu.CherepanovVS.Sprint7.Lib
{
    public class DataService
    {
        public double LoadFromDataFile (string path)
        {
            string[] lines = File.ReadAllLines(path);

            double sum = 0;
            int count = 0;

            foreach (string line in lines)
            {
             
                string[] values = line.Split(',');

                foreach (string value in values)
                {
                    double number;
                    if (double.TryParse(value, out number))
                    {
                        sum += number;
                        count++;
                    }
                }
            }

            double average = sum / count;
            return average;
        }

    }
}
