// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.Clear();

int lines = new Random().Next(0, 10); //рандомное значение строк (0,10)
int columns = new Random().Next(0, 10); //рандомное значение столбцов (0,10)

int[,] array = GetArray(lines, columns, 0, 10);
PrintGetArray(array);

Console.Write("Введите № строки: ");
int lines_2 = int.Parse(Console.ReadLine());
Console.Write("Введите № столбца: ");
int columns_2 = int.Parse(Console.ReadLine());

searchArrayElement(array);


int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }

    return result;
}

void PrintGetArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void searchArrayElement (int[,] inArray)
{
    if (lines_2 < inArray.GetLength(0) && columns_2 < inArray.GetLength(1))
    {
        Console.WriteLine($"Элемент {lines_2},{columns_2} массива равен {inArray[lines_2,columns_2]} ");
    }
    else Console.WriteLine($"Элемент {lines_2},{columns_2} массива не существует! ");
}



