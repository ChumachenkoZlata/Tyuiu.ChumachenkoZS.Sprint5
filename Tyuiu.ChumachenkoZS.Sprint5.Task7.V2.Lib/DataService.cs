
using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task7.V2.Lib
{
    public class DataService
    {
        // Заменяет все цифры в файле на символ #
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string result = "";

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    result += "#";
                }
                else
                {
                    result += c;
                }
            }

            string outPath = Path.Combine(
                Path.GetTempPath(),
                "OutPutDataFileTask7V2.txt"
            );

            File.WriteAllText(outPath, result);

            return outPath;
        }
    }
}
