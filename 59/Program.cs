//  В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] matrix = new int[3, 4];
int[] sumArray = new int[3];

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 2);
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

int[] FillsumArray(int[,] matrix, int[] sumArray)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        int k = i;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            sumArray[k] = sum;
        }
    }
    return sumArray;
}

string FindMin(int[] sumArray)
{
    int k = 0;
    int min = sumArray[k];
    int kMin = 0;
    string res = string.Empty;
    while (k < matrix.GetLength(0))
    {
        if (sumArray[k] <= min)
        {
            min = sumArray[k];
            kMin = k;
            res += $"{kMin + 1} ";
        }
        k++;
    }
    return $"Строка с наименьшей суммой элементов: {res}";
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillsumArray(matrix, sumArray);
Console.WriteLine(FindMin(sumArray));

