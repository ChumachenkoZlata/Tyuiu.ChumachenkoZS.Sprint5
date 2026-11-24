using Tyuiu.ChumachenkoZS.Sprint5.Task0.V7.Lib;

DataService ds = new DataService();

// Строка таблицы шириной 75 символов
static void Row(string text) => Console.WriteLine("* " + text.PadRight(71) + " *");
const string Border = "***************************************************************************";

Console.Title = "Спринт #5 | Выполняла: Чумаченко З. С. | ИБКСб-26-1";
Console.WriteLine(Border);
Row("Спринт #5");
Row("Тема: Работа с файлами");
Row("Задание #0");
Row("Вариант #7");
Row("Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1");
Console.WriteLine(Border);
Row("УСЛОВИЕ:");
Row("Дано выражение F(x) = -x^3 + 4x^2 - 3/2x, вычислить его значение");
Row("при x = 4, результат сохранить в текстовый файл");
Row("OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков");
Row("после запятой.");
Console.WriteLine(Border);
Row("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(Border);
Row("Формула: F(x) = -x^3 + 4x^2 - 3/2x");

int x = 4;
Row($"x = {x}");

string path = ds.SaveToFileTextData(x);

Console.WriteLine(Border);
Row("РЕЗУЛЬТАТ:");
Console.WriteLine(Border);

Console.WriteLine($"F({x}) = " + ds.Calculate(x));
Console.WriteLine("Результат сохранён в файл: " + path);
Console.ReadLine();
