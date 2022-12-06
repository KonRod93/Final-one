/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

/* Вариант решения №1, с заранее заданными данными.*/

string[] arr1 = { "Hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };

int MaxWordLength = 3;

string[] GetShort(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= MaxWordLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Массив пуст");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}

void PrintTask(string[] array)
{
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    string[] shortArray = GetShort(array);
    Console.WriteLine($"Конечный массив (слов меньше или равно, чем {MaxWordLength} символа)");
    PrintArray(shortArray);
    Console.WriteLine();
}

PrintTask(arr1);
PrintTask(arr2);
PrintTask(arr3);


/* Вариант решения №2, через ввод данных.
Console.WriteLine("Введите массив данных через запятую");
string[] array;
string i = Console.ReadLine();
array = i.Split(",");
var result = new string[array.Length];
var count = 0;

foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[count] = value;
        count++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, count));
Console.ReadKey(true); */
