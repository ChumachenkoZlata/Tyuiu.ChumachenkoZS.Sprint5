
using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChumachenkoZS.Sprint5.Task4.V18.Lib
{
    public class DataService
    {
        // y = cos(x) + x^2 / 2
        public double Calculate(string path)
        {
            string str = File.ReadAllText(path);

            double x = Convert.ToDouble(str, CultureInfo.InvariantCulture);

            double res = Math.Cos(x) + Math.Pow(x, 2) / 2;

            return Math.Round(res, 3);
        }
    }
}
