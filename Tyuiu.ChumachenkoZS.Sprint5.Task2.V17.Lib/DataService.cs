
using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChumachenkoZS.Sprint5.Task2.V17.Lib
{
    public class DataService
    {
        // Заменяет все нечётные элементы массива на 0
        public int[,] Calculate(int[,] matrix)
        {
            int[,] res = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        res[i, j] = 0;
                    }
                    else
                    {
                        res[i, j] = matrix[i, j];
                    }
                }
            }

            return res;
        }

        // Сохраняет результат в CSV-файл и возвращает путь к нему
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(
                Path.GetTempPath(),
                "OutPutFileTask2.csv"
            );

            int[,] res = Calculate(matrix);

            string text = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    text += res[i, j].ToString(CultureInfo.InvariantCulture);

                    if (j < 2)
                    {
                        text += ";";
                    }
                }

                if (i < 2)
                {
                    text += Environment.NewLine;
                }
            }

            File.WriteAllText(path, text);

            return path;
        }
    }
}
