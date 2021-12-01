// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] matrix = new int[3, 3];

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

string FindAverage(int[,] matrix)
{
    string average = string.Empty;
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        average += $"{sum / matrix.GetLength(0)} ";
        sum = 0;
    }
    return average;
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(FindAverage(matrix));
