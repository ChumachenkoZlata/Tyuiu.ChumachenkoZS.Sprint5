
using Tyuiu.ChumachenkoZS.Sprint5.Task2.V17.Lib;

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
Row("Задание #2");
Row("Вариант #17");
Row("Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1");
Console.WriteLine(Border);

Row("УСЛОВИЕ:");
Row("Дан двумерный целочисленный массив 3 на 3 элементов,");
Row("заполненный значениями с клавиатуры.");
Row("Заменить нечётные элементы массива на 0.");
Row("Результат сохранить в файл OutPutFileTask2.csv");
Row("и вывести на консоль.");
Console.WriteLine(Border);

Row("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(Border);

int[,] matrix = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Введите элемент [{i},{j}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine();
Row("ИСХОДНЫЙ МАССИВ:");

for (int i = 0; i < 3; i++)
{
    string line = "";

    for (int j = 0; j < 3; j++)
    {
        line += matrix[i, j].ToString().PadLeft(5);
    }

    Console.WriteLine(line);
}

int[,] result = ds.Calculate(matrix);

Console.WriteLine();
Row("РЕЗУЛЬТАТ:");
Console.WriteLine(Border);

for (int i = 0; i < 3; i++)
{
    string line = "";

    for (int j = 0; j < 3; j++)
    {
        line += result[i, j].ToString().PadLeft(5);
    }

    Console.WriteLine(line);
}

string path = ds.SaveToFileTextData(matrix);

Console.WriteLine();
Console.WriteLine("Результат сохранён в файл: " + path);

Console.ReadLine();
