// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

Console.Clear();

Console.Write("Введите колличество строк: ");
int lines = int.Parse(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray (lines, columns, 0, 10);

PrintGetArray(array);

arithmeticСolumns(array);

PrintArithmeticСolumns (arithmeticСolumns(array));


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

void PrintGetArray (int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[] arithmeticСolumns (int[,] inArray)
{
    int[] result = new int[inArray.GetLength(1)];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[j] += inArray[i,j];
            // Console.Write($"{result[j]} ");
        }
    }

    return result;
}

void PrintArithmeticСolumns (int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}
