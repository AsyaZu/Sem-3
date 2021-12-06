// Составить частотный словарь элементов двумерного массива

int[,] matrix = new int[5, 5];

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
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

(int, int) FindMaxMin(int[,] matrix)
{
    int max = 0;
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (matrix[i,j] > max) max = matrix[i,j];
            if (matrix[i,j] < min) min = matrix[i,j];
        }
    }
    return (max, min);
}

void Dict(int[,] data)
{
    var maxMin = FindMaxMin(data);
    int max = maxMin.Item1;
    int min = maxMin.Item2;
    int[] elements = new int[max + Math.Abs(min) + 1];
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            elements[data[i,j] + Math.Abs(min)]++;
        }
    }
    for (int i = 0; i < elements.Length; i++)
    {
        if(elements[i]!=0) System.Console.WriteLine($"{i - Math.Abs(min)} - встречается {elements[i]}");
    }
}

FillArray(matrix);
PrintArray(matrix);
Dict(matrix);