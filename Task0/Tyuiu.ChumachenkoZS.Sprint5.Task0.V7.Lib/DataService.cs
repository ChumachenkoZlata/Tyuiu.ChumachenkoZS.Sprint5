using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChumachenkoZS.Sprint5.Task0.V7.Lib
{
    public class DataService
    {
        // F(x) = -x^3 + 4x^2 - (3/2)x
        public double Calculate(double x)
        {
            double res = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 1.5 * x;
            return Math.Round(res, 3);
        }

        // Вычисляет F(x), сохраняет результат в OutPutFileTask0.txt (временная папка), возвращает путь к файлу
        public string SaveToFileTextData(double x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            double res = Calculate(x);
            File.WriteAllText(path, res.ToString(CultureInfo.InvariantCulture));

            return path;
        }
    }
}
