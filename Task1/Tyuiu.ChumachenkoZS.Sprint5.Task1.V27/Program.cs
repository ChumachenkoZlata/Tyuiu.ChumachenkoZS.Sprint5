using Tyuiu.ChumachenkoZS.Sprint5.Task1.V27.Lib;

DataService ds = new DataService();

// Строка таблицы шириной 75 символов
static void Row(string text) => Console.WriteLine("* " + text.PadRight(71) + " *");
const string Border = "***************************************************************************";

Console.Title = "Спринт #5 | Выполняла: Чумаченко З. С. | ИБКСб-26-1";
Console.WriteLine(Border);
Row("Спринт #5");
Row("Тема: Работа с файлами");
Row("Задание #1");
Row("Вариант #27");
Row("Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1");
Console.WriteLine(Border);
Row("УСЛОВИЕ:");
Row("Дана функция F(x) = (3x - 1,5) / (sin(x) - 3 + x) + 2.");
Row("Произвести табулирование f(x) на заданном диапазоне [-5; 5]");
Row("с шагом 1. Произвести проверку деления на ноль. При делении на");
Row("ноль вернуть значение 0. Результат сохранить в текстовый файл");
Row("OutPutFileTask1.txt и вывести на консоль в таблицу. Значения");
Row("округлить до двух знаков после запятой.");
Console.WriteLine(Border);
Row("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(Border);
Row("Формула: F(x) = (3x - 1,5) / (sin(x) - 3 + x) + 2");

int startValue = -5;
int stopValue = 5;
Row($"Диапазон: [{startValue}; {stopValue}], шаг 1");

double[] values = ds.GetMassFunction(startValue, stopValue);
string path = ds.SaveToFileTextData(startValue, stopValue);

Console.WriteLine(Border);
Row("РЕЗУЛЬТАТ:");
Console.WriteLine(Border);

Console.WriteLine("+----------+--------------+");
Console.WriteLine("|    x     |     F(x)     |");
Console.WriteLine("+----------+--------------+");
for (int i = 0; i < values.Length; i++)
{
    Console.WriteLine($"| {(startValue + i),8} | {values[i].ToString("F2"),12} |");
}
Console.WriteLine("+----------+--------------+");

Console.WriteLine("Результат сохранён в файл: " + path);
Console.ReadLine();
