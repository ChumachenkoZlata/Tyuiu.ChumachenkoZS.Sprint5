
using Tyuiu.ChumachenkoZS.Sprint5.Task5.V17.Lib;
using System.IO;

DataService ds = new DataService();

// Строка таблицы шириной 75 символов
static void Row(string text) =>
    Console.WriteLine("* " + text.PadRight(71) + " *");

const string Border =
    "*****************************************************************************";

Console.Title = "Спринт #5 | Выполняла: Чумаченко З. С. | ИБКСб-26-1";

Console.WriteLine(Border);
Row("Спринт #5");
Row("Тема: Работа с файлами");
Row("Задание #5");
Row("Вариант #17");
Row("Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1");
Console.WriteLine(Border);

Row("УСЛОВИЕ:");
Row("Дан файл с набором значений.");
Row("Найти сумму всех простых целых чисел в файле.");
Row("Вещественные значения округлить до трёх знаков");
Row("после запятой.");
Console.WriteLine(Border);

Row("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(Border);

string path = Path.Combine(
    Path.GetTempPath(),
    "InPutDataFileTask5V17.txt"
);

// Копируем исходный файл в временную папку
string sourcePath =
    @"C:\Users\zolot\source\repos\Tyuiu.ChumachenkoZS.Sprint5\Tyuiu.ChumachenkoZS.Sprint5\DataSprint5\InPutDataFileTask5V17.txt";

File.Copy(sourcePath, path, true);

Row("Имя файла: InPutDataFileTask5V17.txt");
Row("Путь к файлу: " + path);

int result = ds.Calculate(path);

Console.WriteLine(Border);
Row("РЕЗУЛЬТАТ:");
Console.WriteLine(Border);

Row("Сумма простых целых чисел = " + result);

Console.WriteLine(Border);
Console.ReadLine();
