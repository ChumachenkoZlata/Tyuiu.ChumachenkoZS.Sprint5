
using Tyuiu.ChumachenkoZS.Sprint5.Task7.V2.Lib;
using System.IO;

DataService ds = new DataService();

// Строка таблицы шириной 75 символов
static void Row(string text) => Console.WriteLine("* " + text.PadRight(71) + " *");

const string Border = "*****************************************************************************";

Console.Title = "Спринт #5 | Выполняла: Чумаченко З. С. | ИБКСб-26-1";

Console.WriteLine(Border);
Row("Спринт #5");
Row("Тема: Работа с файлами");
Row("Задание #7");
Row("Вариант #2");
Row("Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1");
Console.WriteLine(Border);

Row("УСЛОВИЕ:");
Row("Дан файл с набором символьных данных.");
Row("Заменить все цифры на символ #.");
Row("Полученный результат сохранить в файл");
Row("OutPutDataFileTask7V2.txt.");
Console.WriteLine(Border);

Row("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(Border);

string inputPath = Path.Combine(
    @"C:\Users\zolot\source\repos\Tyuiu.ChumachenkoZS.Sprint5\Tyuiu.ChumachenkoZS.Sprint5\DataSprint5",
    "InPutDataFileTask7V2.txt"
);

string text = File.ReadAllText(inputPath);

Console.WriteLine(text);

string path = ds.LoadDataAndSave(inputPath);

Console.WriteLine(Border);
Row("РЕЗУЛЬТАТ:");
Console.WriteLine(Border);

Console.WriteLine(File.ReadAllText(path));

Console.WriteLine();
Console.WriteLine("Результат сохранён в файл: " + path);

Console.ReadLine();
