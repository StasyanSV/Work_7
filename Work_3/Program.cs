// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

Console.Clear();

Console.Write("Введите колличество строк: ");
int lines = int.Parse(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray (lines, columns, 0, 10);

PrintGetArray(array);

arithmeticСolumns(array);

PrintArithmeticСolumns (arithmeticСolumns(array));


double[,] GetArray(int n, int m, int minValue, int maxValue)
{
    double[,] result = new double[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }

    return result;
}

void PrintGetArray (double[,] inArray)
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

double[] arithmeticСolumns (double[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[j] += inArray[i,j];
            // Console.Write($"{result[j]} ");
        }
    }

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Round((result[i]/ inArray.GetLength(0)),2);
    }

    return result;
}

void PrintArithmeticСolumns (double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}
