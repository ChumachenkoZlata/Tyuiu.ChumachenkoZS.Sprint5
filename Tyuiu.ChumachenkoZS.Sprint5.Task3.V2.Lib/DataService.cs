
using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task3.V2.Lib
{
    public class DataService
    {
        // y = e^x / x
        public double Calculate(double x)
        {
            double res = Math.Exp(x) / x;
            return Math.Round(res, 3);
        }

        // Вычисляет y, сохраняет результат в бинарный файл
        public string SaveToFileBinaryData(double x)
        {
            string path = Path.Combine(
                Path.GetTempPath(),
                "OutPutFileTask3.bin"
            );

            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            double res = Calculate(x);

            using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(path)))
            {
                writer.Write(res);
            }

            return path;
        }
    }
}
