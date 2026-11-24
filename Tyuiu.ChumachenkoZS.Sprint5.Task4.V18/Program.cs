
using Tyuiu.ChumachenkoZS.Sprint5.Task4.V18.Lib;
using System.Globalization;
using System.IO;

DataService ds = new DataService();

// Строка таблицы шириной 75 символов
static void Row(string text) => Console.WriteLine("* " + text.PadRight(71) + " *");

const string Border = "*****************************************************************************";

Console.Title = "Спринт #5 | Выполняла: Чумаченко З. С. | ИБКСб-26-1";

Console.WriteLine(Border);
Row("Спринт #5");
Row("Тема: Работа с файлами");
Row("Задание #4");
Row("Вариант #18");
Row("Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1");
Console.WriteLine(Border);

Row("УСЛОВИЕ:");
Row("Дан текстовый файл с вещественным значением.");
Row("Прочитать значение из файла и вычислить выражение:");
Row("y = cos(x) + x^2 / 2.");
Row("Результат округлить до трёх знаков после запятой.");
Console.WriteLine(Border);

Row("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(Border);

string path = Path.Combine(
    @"C:\Users\zolot\source\repos\Tyuiu.ChumachenkoZS.Sprint5\Tyuiu.ChumachenkoZS.Sprint5\DataSprint5",
    "InPutDataFileTask4V18.txt"
);

string str = File.ReadAllText(path);

double x = Convert.ToDouble(str, CultureInfo.InvariantCulture);

Row("Формула: y = cos(x) + x^2 / 2");
Row($"x = {x}");

double result = ds.Calculate(path);

Console.WriteLine(Border);
Row("РЕЗУЛЬТАТ:");
Console.WriteLine(Border);

Console.WriteLine($"y = cos({x}) + {x}^2 / 2");
Console.WriteLine("Ответ: " + result.ToString("F3", CultureInfo.InvariantCulture));

Console.ReadLine();
