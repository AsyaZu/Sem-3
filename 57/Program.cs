// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива

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

void ChangeArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int jMax = 0;
            int max = matrix[i, j];
            if  (matrix[i, j + 1] > max)
            {
                max = matrix[i, j + 1];
                jMax = j;
            }
            
            
        }
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeArray(matrix);
PrintArray(matrix);// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива

int[,] matrix = new int[3, 7];

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

void ChangeArray(int[,] matrix)
{
    int save = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j + 1] > matrix[i, j])
                {
                    save = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = save;
                }
            }
        }
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeArray(matrix);
PrintArray(matrix);


