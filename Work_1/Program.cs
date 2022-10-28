// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

Console.Clear();

Console.Write("Введите колличество строк: ");
int lines = int.Parse(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(lines, columns);
PrintGetArray(array);


double[,] GetArray(int n, int m)
{
    double[,] result = new double[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble()*10, 2);
        }
    }

    return result;
}

void PrintGetArray(double[,] inArray)
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