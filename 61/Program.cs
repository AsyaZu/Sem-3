// Найти произведение двух матриц

int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 3);
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

int Multiplication(int[,] matrix1, int[,] matrix2)
{
    int mult1 = 1;
    int mult2 = 1;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            mult1 = mult1 * matrix1[i, j];
        }
    }
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            mult2 = mult2 * matrix2[i, j];
        }
    }
    return mult1 * mult2;
}

FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine(Multiplication(matrix1, matrix2));