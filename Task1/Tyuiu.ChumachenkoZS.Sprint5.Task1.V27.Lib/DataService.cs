using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChumachenkoZS.Sprint5.Task1.V27.Lib
{
    public class DataService
    {
        // F(x) = (3x - 1.5) / (sin(x) - 3 + x) + 2
        // При делении на ноль возвращается 0
        public double Calculate(double x)
        {
            double denominator = Math.Sin(x) - 3 + x;
            if (denominator == 0)
            {
                return 0;
            }

            double res = (3 * x - 1.5) / denominator + 2;
            return Math.Round(res, 2);
        }

        // Табулирование F(x) на отрезке [startValue; stopValue] с шагом 1
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                valueArray[i] = Calculate(startValue + i);
            }

            return valueArray;
        }

        // Сохраняет значения F(x) в OutPutFileTask1.txt (временная папка, по одному значению в строке),
        // возвращает путь к файлу
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            double[] values = GetMassFunction(startValue, stopValue);
            string[] lines = new string[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                lines[i] = values[i].ToString(CultureInfo.InvariantCulture);
            }

            File.WriteAllLines(path, lines);

            return path;
        }
    }
}
