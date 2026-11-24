
using Tyuiu.ChumachenkoZS.Sprint5.Task3.V2.Lib;

DataService ds = new DataService();

// Строка таблицы шириной 75 символов
static void Row(string text) =>
    Console.WriteLine("* " + text.PadRight(71) + " *");

const string Border = "*****************************************************************************";

Console.Title = "Спринт #5 | Выполняла: Чумаченко З. С. | ИБКСб-26-1";

Console.WriteLine(Border);
Row("Спринт #5");
Row("Тема: Работа с файлами");
Row("Задание #3");
Row("Вариант #2");
Row("Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1");
Console.WriteLine(Border);

Row("УСЛОВИЕ:");
Row("Дано выражение y = e^x / x, вычислить его значение");
Row("при x = 3, результат сохранить в бинарный файл");
Row("OutPutFileTask3.bin и вывести на консоль.");
Row("Округлить до трёх знаков после запятой.");
Console.WriteLine(Border);

Row("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(Border);

Row("Формула: y = e^x / x");

int x = 3;
Row($"x = {x}");

string path = ds.SaveToFileBinaryData(x);

Console.WriteLine(Border);
Row("РЕЗУЛЬТАТ:");
Console.WriteLine(Border);

Console.WriteLine($"y = {ds.Calculate(x)}");
Console.WriteLine("Результат сохранён в файл: " + path);

Console.ReadLine();
