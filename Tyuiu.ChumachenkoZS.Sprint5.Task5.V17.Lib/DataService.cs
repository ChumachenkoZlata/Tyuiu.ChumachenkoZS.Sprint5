
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task5.V17.Lib
{
    public class DataService
    {
        // Проверка числа на простоту
        private bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        // Считывает числа из файла и находит сумму простых целых чисел
        public int Calculate(string path)
        {
            string text = File.ReadAllText(path);

            string[] values = text.Split(
                new char[] { ' ', '\n', '\r', '\t', ';', ',' },
                StringSplitOptions.RemoveEmptyEntries
            );

            int sum = 0;

            foreach (string value in values)
            {
                double number = double.Parse(
                    value,
                    CultureInfo.InvariantCulture
                );

                number = Math.Round(number, 3);

                if (number == Math.Truncate(number) &&
                    number >= int.MinValue &&
                    number <= int.MaxValue)
                {
                    int integerNumber = (int)number;

                    if (IsPrime(integerNumber))
                    {
                        sum += integerNumber;
                    }
                }
            }

            return sum;
        }
    }
}
