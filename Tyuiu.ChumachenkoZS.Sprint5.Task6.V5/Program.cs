
using Tyuiu.ChumachenkoZS.Sprint5.Task6.V5.Lib;

DataService ds = new DataService();

static void Row(string text) => Console.WriteLine("* " + text.PadRight(71) + " *");

const string Border = "***************************************************************************";

Console.Title = "Спринт #5 | Выполняла: Чумаченко З. С. | ИБКСб-26-1";

Console.WriteLine(Border);
Row("Спринт #5");
Row("Тема: Работа с файлами");
Row("Задание #6");
Row("Вариант #5");
Row("Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1");
Console.WriteLine(Border);

Row("УСЛОВИЕ:");
Row("Дан файл с набором символьных данных.");
Row("Найти количество заглавных латинских букв в заданной строке.");
Console.WriteLine(Border);

Row("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(Border);

string path = Path.Combine(
    Path.GetFullPath(@"C:\Users\zolot\source\repos\Tyuiu.ChumachenkoZS.Sprint5\Tyuiu.ChumachenkoZS.Sprint5\DataSprint5"),
    "InPutDataFileTask6V5.txt"
);

Row("Файл: InPutDataFileTask6V5.txt");

int res = ds.Calculate(path);

Console.WriteLine(Border);
Row("РЕЗУЛЬТАТ:");
Console.WriteLine(Border);

Console.WriteLine("Количество заглавных латинских букв: " + res);

Console.ReadLine();
